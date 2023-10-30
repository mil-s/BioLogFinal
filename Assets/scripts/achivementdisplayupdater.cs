using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;




public class achivementdisplayupdater : MonoBehaviour
{

    public TMP_Text achievementdisplay;
    public TMP_Text sitzungstext;
    public GameObject haken;

    public static int solvedach; 
    public static int allach; 

    public GameObject achievementbutton;

    //this script handles the yellow button that displays the amount of solved missions
   
   void Start()
   {
     achievementdisplay.text = "0/0";

     // hides button if the A/B/C version of the game is not played
     if(main.gw == 0){achievementbutton.SetActive(false);} else {}
    
   }

   //Update:
   //number of existing and solved achievements are calculated by summing up the values of 1 in their respective lists
   //these numbers are displayed on the yellow button
   //if the numbers are equal, all missions have been solved, and a green checkmark is displayed


    void Update()
    {
        allach = achievements.achievementcounter.Sum();
        solvedach = achievements.achievementsolved.Sum();


        sitzungstext.text = "Sitzung " + main.sitzungsnr;
        achievementdisplay.text = solvedach + "/" + allach;
        
        if(allach > 0)
        {
        if (allach == solvedach) 
        {
            haken.SetActive(true);
        }
        else 
        {
            haken.SetActive(false);
        }
        }
        else {}
    }
}
