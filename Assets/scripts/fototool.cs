using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fototool : MonoBehaviour
{
    public GameObject caminterface;
    public GameObject minimap;
    public GameObject kalender;
    public GameObject dunkelgebiet;
    public static int animalunlock = 0;
    // Start is called before the first frame update
    
    public void fototoolclick ()

    //when the photo tool is not already in use (animalunlock is 0):
    //the camera interface becomes visible
    //some UI elements are deactivated so they dont interfere
    //animalunlock is set to 1: animals are now able to be photographed
    //when the photo tool is already in use (animalunlock is 1), clicking on it again does the reverse

    {
        print (animalunlock);

        if (animalunlock == 0)
        {
        animalunlock = 1;
        caminterface.SetActive(true);
        kalender.SetActive(false);
        dunkelgebiet.SetActive(false);
        lupe.lupenclicked = 0;
        print (animalunlock);
        if(minimap != null){minimap.SetActive(false);}
        }

        else if (animalunlock == 1)
        {
        animalunlock = 0;
        caminterface.SetActive(false);
        if(minimap != null){minimap.SetActive(true);}
        kalender.SetActive(true);
        }
    }

    void Update()

    //checks if the magnifying glass is active
    //if yes: deactivates photo tool changes
    
    {
        if (lupe.lupenclicked == 1)
        {
        animalunlock = 0;
        caminterface.SetActive(false);
        if(minimap != null){minimap.SetActive(true);}
        kalender.SetActive(true);
        }
    }
}
