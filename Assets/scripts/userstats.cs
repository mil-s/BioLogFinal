using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class userstats : MonoBehaviour
{

public TMP_Text userstat;
public TMP_Text sitzungstat;

//displays the username and session number at the top right of the screen

void Start()

    {
      userstat.text = "Willkommen, " + main.username;
      sitzungstat.text = "Sitzung: " + main.sitzungsnr;
    }

   
}
