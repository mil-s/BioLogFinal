using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achievementverhalten : MonoBehaviour
{

   public int achievementnr;
   public static int currentachievement = 0;

   //infoclick:
   //opens the mission info panel when the info button on a mission is clicked
   //(on a technical level, this is activated by clicking anywhere on the mission blob itself, not just the info button)
   //sets the currentachievement variable to the one of the achievement whose info button has been clicked
   
   public void infoclick()

   {
    print(achievementnr);

    currentachievement = achievementnr;

    GameObject.Find("AllPanels").transform.GetChild(7).gameObject.gameObject.SetActive(true);

   }

}
