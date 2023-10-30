using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class tierverhalten : MonoBehaviour
{


public Image leximage;
public Sprite leximagedisplay;
public Button leximagebutton;
public TMP_Text lexinfotext;
public Image lexinfoimage;
public Sprite lexinfodisplay;
public GameObject Panel;
public TMP_Text notizenfeld;
public GameObject map;


// old script for organism behavior

public void photoclick(int tierNr)

{
    print ("scene ist   " + SceneManager.GetActiveScene().buildIndex);
    if (!(SceneManager.GetActiveScene().buildIndex == 6))
    {

print ("scene ist   " + SceneManager.GetActiveScene().buildIndex);
    main.tierListe[tierNr] = 1;
 
    lexinfotext.text = main.tierInfo[tierNr];
    lexinfoimage.sprite = lexinfodisplay;
    leximage.sprite = leximagedisplay;
    notizen.notizenvariable = tierNr;
    notizenfeld.text = main.tierNotizen[tierNr];
    //leximagebutton.enabled = false;
    //leximagebutton.GetComponent<hidelex>().hideLex(Panel);
    }

}

private int walkcounter = 0;
private int timecounter = 0;
private int xval;
private int yval;
private int xtime;
private int urcounter = 0;
private int ulcounter = 0;
private int olcounter = 0;
private int orcounter = 0;
private int countermax = 200;


void Update()
{
xval = Random.Range(0, 5);
xtime = Random.Range(1, 40000);


    switch(walkcounter)
    {
    case 0:
    if (urcounter < countermax) {transform.Translate(0.5f, -0.5f, 0); timecounter += 1; urcounter +=1; olcounter -=1;}
    else {walkcounter = xval; timecounter = 0;};
    
    if(timecounter >= xtime) {walkcounter = xval; timecounter = 0;};
    break;

    case 1:

    if (ulcounter < countermax) {transform.Translate(-0.5f, -0.5f, 0); timecounter += 1; ulcounter +=1; orcounter -=1;}
    else {walkcounter = xval; timecounter = 0;};
    
    if(timecounter >= xtime) {walkcounter = xval; timecounter = 0;};
    break;

    case 2:
    
    if (olcounter < countermax) {transform.Translate(-0.5f, 0.5f, 0); timecounter += 1; olcounter +=1; urcounter -=1;}
    else {walkcounter = xval; timecounter = 0;};
    
    if(timecounter >= xtime) {walkcounter = xval; timecounter = 0;};
    break;

    case 3:
   
    if (orcounter < countermax) {transform.Translate(0.5f, 0.5f, 0); timecounter += 1; orcounter +=1; ulcounter -=1;}
    else {walkcounter = xval; timecounter = 0;};
    
    if(timecounter >= xtime) {walkcounter = xval; timecounter = 0;};
    break;

    case 4:
    
    timecounter += 1;
    if(timecounter >= 2*xtime) {walkcounter = xval; timecounter = 0;};
    break;



    }
}

}
