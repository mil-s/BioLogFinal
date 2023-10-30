using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

public GameObject spawnobjekt;
public GameObject map;

private SpriteRenderer spriterenderer;
private SpriteRenderer objektrenderer;
public int Anzahl;
private static float xmin;
private static float xmax;
private static float ymin;
private static float ymax;


//this script controls how the organisms and objects are spawned


//Start:
//script appended to objects to duplicate and spawn them at the beginning of the game

void Start()
{  
    //analogous to the camera function, borders of the spawn areas are calculated 
    //by finding the map borders through its size values and substracting the relevant object size value

        spriterenderer = map.GetComponent<SpriteRenderer>();
        objektrenderer = spawnobjekt.GetComponent<SpriteRenderer>();

        xmin = (spriterenderer.transform.position.x - spriterenderer.bounds.size.x/2f) + objektrenderer.bounds.size.x;
        xmax = (spriterenderer.transform.position.x + spriterenderer.bounds.size.x/2f) - objektrenderer.bounds.size.x;
        ymin = (spriterenderer.transform.position.y - spriterenderer.bounds.size.y/2f) + objektrenderer.bounds.size.y;
        ymax = (spriterenderer.transform.position.y + spriterenderer.bounds.size.y/2f) - objektrenderer.bounds.size.y;

//new position is calculated based on a random value inside the spawn area borders
//object is instantiated at this position
//repeated by the amount of variable i

    for (var i = 0; i < (Anzahl); i++)
        {
            Vector3 randompos = new Vector3(Random.Range(xmin, xmax)+i, Random.Range(ymin, ymax), 0);
            Instantiate(spawnobjekt, randompos, Quaternion.identity);
        }
}

//spawnerfunction:
//function used in other scripts to spawn objects

public static void spawnerfunction(GameObject spawnobj, GameObject spawnmap, int anzahl, string parent, float dimension1, float dimension2)
{  
    //analogous to the camera function, borders of the spawn areas are calculated 
    //by finding the map borders through its size values and substracting the relevant object size value

        SpriteRenderer spriterend = spawnmap.GetComponent<SpriteRenderer>();
        SpriteRenderer objektrend = spawnobj.GetComponent<SpriteRenderer>();

        xmin = (spriterend.transform.position.x - spriterend.bounds.size.x/2f) + objektrend.bounds.size.x;
        xmax = (spriterend.transform.position.x + spriterend.bounds.size.x/2f) - objektrend.bounds.size.x;
        ymin = (spriterend.transform.position.y - spriterend.bounds.size.y/2f) + objektrend.bounds.size.y;
        ymax = (spriterend.transform.position.y + spriterend.bounds.size.y/2f) - objektrend.bounds.size.y;


    for (var i = 0; i < (anzahl+1); i++)
        {
            //random position is created through calculating a random vector within the map borders 
            //a copy of the object is instantiated at that position
            //the size of the new object is calculated by creating a random number within the two set dimension limits
            //and putting that number into a vector for the object scale to be transformed into

            Vector3 randompos = new Vector3(Random.Range(xmin, xmax)+i, Random.Range(ymin, ymax), 0);
            Instantiate(spawnobj, randompos, Quaternion.identity);
            spawnobj.transform.SetParent(GameObject.Find(parent).transform);
            float dim = Random.Range(dimension1, dimension2);

            //Vector3 resize = spawnobj.transform.localScale;
            //resize *= dim;
            Vector3 resize = new Vector3(dim, dim, dim);
            
            spawnobj.transform.localScale = resize;
        }
    

}



}
