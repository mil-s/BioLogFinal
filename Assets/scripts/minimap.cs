using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour
{
    public GameObject mapmarker;

    void Update()

    //mapmarker is a rectangle shaped game object only visible to the minimap camera displayed on the minimap texture
    //its size and position is updated to mirror the size and position of the player camera
    //this creates the effect of the player's field of vision being tracked on the minimap

    {
        mapmarker.transform.localScale = new Vector3(newcammove.width, newcammove.height, 0);
        mapmarker.transform.position = new Vector3(newcammove.currentposi.x, newcammove.currentposi.y, 0);

    }
   
}


// minimap feature inspired by https://www.youtube.com/watch?v=kWhOMJMihC0
// changed in some aspects to fit the requirements of the project but uses the same idea and setup