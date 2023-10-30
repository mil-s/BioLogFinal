using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lexupdater : MonoBehaviour
{

public Image leximage;
public GameObject leximagebutton;
public int tierNr;



public void lexclick()

{
   //when an icon in the lexicon is clicked, the organism info panel is opened
   //2 variables are updated to match the organism whose icon was clicked; they are used in a different script to pull the relevant information on the organism

   if (main.tierListe[tierNr] == 1)

   {
      notizen.notizenvariable = tierNr;
      
      leximagebutton.GetComponent<hidelex>().hideLex( GameObject.Find("AllPanels").transform.GetChild(4).gameObject.gameObject);
     

      tierverhalten2.currentTier = tierNr;
   }


}

public void Update()

{
   //lexicon question mark icon is updated to reflect the organism icon once it is unlocked

  if (main.tierListe[tierNr] == 1)
  {
    leximage.sprite = main.iconsprites[tierNr];
    //leximagebutton.enabled = true;
  }
}

}
