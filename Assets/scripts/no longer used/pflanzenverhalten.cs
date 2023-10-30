using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class pflanzenverhalten : MonoBehaviour
{

public int tierNr;
public static int currentTier = 0;
public GameObject tierobjekt;



    public void plantclick()
    {

        //if (main.sitzungsnr > 1)
    {

// old script for static organisms

        main.tierListe[tierNr] = 1;

        notizen.notizenvariable = tierNr;

        currentTier = tierNr;

        GameObject.Find("AllPanels").transform.GetChild(4).gameObject.gameObject.SetActive(true);

        if (main.camlock == 0) {main.camlock = 1;}
            else {main.camlock = 0;}
    }
        

    
    
}
}
