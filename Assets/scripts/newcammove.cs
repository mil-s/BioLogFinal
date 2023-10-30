using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newcammove : MonoBehaviour
{

[SerializeField]
private Camera thecamera;
public SpriteRenderer maprenderer;

[SerializeField]
private float zoomStep, mincamsize, maxcamsize;

public static Vector3 cursorpos;
private Vector3 newposi;
public static Vector3 currentposi;
public static float currentsize;
public static float height;
public static float width;

private float rightborder;
private float leftborder;
private float upborder;
private float downborder;

public static float zoominlimit = 0;
public static float zoomoutlimit = 0;

private GameObject map;

public static int cameramoved = 0;

public static List<int> zoomgebiete = new List<int>(){1,4,5,7};






public void Awake()

{
    
}

public void Start()

{
//map border limits as well as minimum and maximum size of the camera are set

bordermaker();

mincamsize = 0.001f*thecamera.orthographicSize;
maxcamsize = maprenderer.bounds.size.x / 4f;
//(Mathf.FloorToInt(maprenderer.transform.position.x/thecamera.orthographicSize))*thecamera.orthographicSize;

if (swapscene.scenechanged == 1)

//when a player clicks on a zoom object, the values of the previous camera size and position in the forest area are saved
//here, the game checks if the player is returning from a zoom area
//if yes (== 1), the camera values are updated to the previously saved ones, and the scene change tracking value is reset

    {
    
    thecamera.transform.position = swapscene.saveposi;
    print(thecamera.transform.position);
    thecamera.orthographicSize = swapscene.savesize; 
    swapscene.scenechanged = 0;
    }

zoomin(20);
zoomout(20);

}

public void bordermaker()

//sets limits of where the camera can be dragged so it stops at the edges of the map
//uses map size and attributes to calculate

{
leftborder = maprenderer.transform.position.x - (maprenderer.bounds.size.x / 2f) + 2f*thecamera.orthographicSize;
rightborder = maprenderer.transform.position.x + (maprenderer.bounds.size.x / 2f)- 2f*thecamera.orthographicSize;
downborder = maprenderer.transform.position.y - (maprenderer.bounds.size.y / 2f) + thecamera.orthographicSize;
upborder = maprenderer.transform.position.y + (maprenderer.bounds.size.y / 2f) - thecamera.orthographicSize;
}

public void cammover()
{
    //takes position of the mouse button down at two points in time, calculates the difference
    //creates a new position that is the current camera position + the newly calculated difference
    
    if (Input.GetMouseButtonDown(0))
    {
        cursorpos = thecamera.ScreenToWorldPoint(Input.mousePosition);
        

    }

    if (Input.GetMouseButton(0))
    {
        Vector3 difference = cursorpos - thecamera.ScreenToWorldPoint(Input.mousePosition);
        newposi = thecamera.transform.position + difference;

        //if the newly created position goes beyond the border limits
        //the offending aspect of the new position is reset to the border limit

        if (newposi.x > rightborder) {newposi.x = rightborder;}
        if (newposi.x < leftborder) {newposi.x = leftborder;}
        if (newposi.y > upborder) {newposi.y = upborder;}
        if (newposi.y < downborder) {newposi.y = downborder;}


        //camera position is updated to the newly calculated position

        thecamera.transform.position = newposi;


        //leftover tracking variable for a currently scrapped mission
        if (difference.y > 0)
        {cameramoved = 1;}


    }

}

public void zoomin(float zoomStep)

{
    //calculates new size of the camera by substracting the zoomstep (degree of zoom)
    float newsize = thecamera.orthographicSize - zoomStep;
    thecamera.orthographicSize = Mathf.Clamp(newsize, mincamsize, maxcamsize);

    //repeats camera movement function
    bordermaker();
    cursorpos = thecamera.ScreenToWorldPoint(Input.mousePosition);
    Vector3 difference = cursorpos - thecamera.ScreenToWorldPoint(Input.mousePosition);
        newposi = thecamera.transform.position + difference;

        if (newposi.x > rightborder) {newposi.x = rightborder;}
        if (newposi.x < leftborder) {newposi.x = leftborder;}
        if (newposi.y > upborder) {newposi.y = upborder;}
        if (newposi.y < downborder) {newposi.y = downborder;}



        thecamera.transform.position = newposi;

        
        if (difference.y > 0)
        {cameramoved = 1;}
    
    //thecamera.orthographicSize = newsize;
    
}

public void zoomout(float zoomStep)

{
    //calculates new size of the camera by adding the zoom step (degree of zoom)
    float newsize = thecamera.orthographicSize + zoomStep;
    thecamera.orthographicSize = Mathf.Clamp(newsize, mincamsize, maxcamsize);

    //repeats camera movement function
    bordermaker();
    cursorpos = thecamera.ScreenToWorldPoint(Input.mousePosition);
    Vector3 difference = cursorpos - thecamera.ScreenToWorldPoint(Input.mousePosition);
        newposi = thecamera.transform.position + difference;

        if (newposi.x > rightborder) {newposi.x = rightborder;}
        if (newposi.x < leftborder) {newposi.x = leftborder;}
        if (newposi.y > upborder) {newposi.y = upborder;}
        if (newposi.y < downborder) {newposi.y = downborder;}



        thecamera.transform.position = newposi;

        
        if (difference.y > 0)
        {cameramoved = 1;}
    //thecamera.orthographicSize = newsize;
    
}

public void Update()

{

//camera movement is calculated each update
//some objects require that the camera cant be used, so the camlock variable stops camera functions

if (main.camlock == 0)
{
cammover();

}



if (main.camlock == 0)
{
//zoom only works in the main forest areas whose scene numbers are saved in zoomgebiete

if (zoomgebiete.Contains(SceneManager.GetActiveScene().buildIndex))
{
    //on mouse scroll wheel input, camera is zoomed in or out by the value of 20
    //zoominlimit and zoomoutlimit are used to control how far it can be zoomed in or out

 if (Input.GetAxis("Mouse ScrollWheel") > 0)
     {
        if (zoominlimit < 10)
         {
            zoomin(20);
            zoominlimit +=1;
            zoomoutlimit -= 1;
         }
     }

     if (Input.GetAxis("Mouse ScrollWheel") < 0)
     {
        if (zoomoutlimit < 20)
         {
            zoomout(20);
            zoomoutlimit += 1;
            zoominlimit -= 1;
         }
     }
}
}

//camera data is saved on update for scripts that need it

currentposi = thecamera.transform.position;
currentsize = thecamera.orthographicSize;
height = 2f * currentsize;
width = height * thecamera.aspect;

}


}

// camera movement and zoom adapted from here: https://youtu.be/R6scxu1BHhs