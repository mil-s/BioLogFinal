using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swapscene : MonoBehaviour
   {

   public static Vector3 saveposi;
   public static float savesize;
   public static int scenechanged = 0;
   

   public static void nextscene (int sceneID)

   //changes scene into a new location
   //saves camera size and position
   //saves ID of prior scene 
   //changes scene counter to the upcoming scene

   {
    saveposi = newcammove.currentposi;
    savesize = newcammove.currentsize;
    main.lastscene = SceneManager.GetActiveScene().buildIndex;
    SceneManager.LoadScene(sceneID);
    main.camlock = 0;
    main.scenecounter = sceneID;
    
   


   }

   //return from the changed location
   //loads up the prior scene
   //changes current scene counter back to the prior scene
   //resets magnifying glass and photo tool to not active

   public static void returnscene ()

   {
      SceneManager.LoadScene(main.lastscene);
      main.camlock = 0;
      main.scenecounter = main.lastscene;
      lupe.lupenclicked = 0;
      fototool.animalunlock = 0;
      scenechanged = 1;
   }
}

