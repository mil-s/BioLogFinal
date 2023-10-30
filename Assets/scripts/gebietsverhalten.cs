using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gebietsverhalten : MonoBehaviour
{

    public Sprite leuchtgebiet;
    public Sprite normalgebiet;
    public GameObject gebiet;
    public static int clickable;
    public int sceneID;
    public SpriteRenderer spriterenderer;

    public static int bluetencounter = 0;
    public static int baumcounter = 0;
    public static int huegelcounter = 0;

    void Start()
    {
        spriterenderer = gebiet.GetComponent<SpriteRenderer>();
    }

    //this script controls the behavior of the zoom objects

    void Update()
    {

        //if the magnifying glass has been clicked, the zoom object sprite changes to a glowing version 
        //and its clickable variable becomes 1

        if (lupe.lupenclicked == 1)
        {
            spriterenderer.sprite = leuchtgebiet;
            clickable = 1;

        }

        else 
        {
            spriterenderer.sprite = normalgebiet;
            clickable = 0;
        }
    }

    public void clickgebiet ()
    {
        //if the zoom object is clicked while clickable is 1:
        //camera position and size of the main forest area is saved
        //scene IDs of the upcoming scene and the current main forest area are saved
        //a few variables such as clickable are reset to their starting value of 0 in preparation for the scene change
        //variables are updated to reflect which zoom area is being visited
        //next scene is loaded up

        if (clickable == 1)
        {
            swapscene.saveposi = newcammove.currentposi;
            swapscene.savesize = newcammove.currentsize;
            print(swapscene.saveposi);
            lupe.lupenclicked = 0;
            clickable = 0;
            main.scenecounter = sceneID;
            main.lastscene = SceneManager.GetActiveScene().buildIndex;
            main.camlock = 0;
            if (sceneID == 8) {bluetencounter = 1;} else {}
            if (sceneID == 2) {baumcounter = 1;} else {}
            if (sceneID == 6) {huegelcounter = 1;} else {}
            SceneManager.LoadScene(sceneID);
        }
        else {}

    }
    



}
