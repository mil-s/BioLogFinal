using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lupe : MonoBehaviour
{

    public GameObject dunkelgebiet;
    public GameObject caminterface;
    public static int lupenclicked = 0;


    public void lupenclick()

    {
        //when the magnifying glass is clicked, the dark overlay image is activated
        //cam interface is closed
        //animalunlock is set 0 and lupenclicked is set 1: zoom objects can be interacted with but not organisms
        //if the magnifying glass was already active, the dark overlay is deactivated and lupenclicked is set to 0 instead


        if (lupenclicked == 0)
        {
            dunkelgebiet.SetActive(true);
            caminterface.SetActive(false);
            fototool.animalunlock = 0;
            lupenclicked = 1;

        }

        else if (lupenclicked == 1)
        {
            dunkelgebiet.SetActive(false);
            lupenclicked = 0;
            

        }
    }
    
  


}
