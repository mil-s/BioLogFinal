using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class tierverhalten2 : MonoBehaviour
{

public int tierNr;
public static int currentTier = 0;
public GameObject tierobjekt;
public int isstatic;


//function for the photo tool interactions

    public void tierclick()
    {

        if (lupe.lupenclicked == 0)
    {
        print(fototool.animalunlock);

        if (fototool.animalunlock == 1)
        {

// if the magnifying glass is not active but the photo tool is active
// clicking on an animal causes:
// updates its position in the organism unlock list to 1
// sets the notes and current organism variables to the clicked organism and opens up the info panel
// locks camera for the info panel

        main.tierListe[tierNr] = 1;

        notizen.notizenvariable = tierNr;

        currentTier = tierNr;

        GameObject.Find("AllPanels").transform.GetChild(4).gameObject.gameObject.SetActive(true);

        if (main.camlock == 0) {main.camlock = 1;}
            else {main.camlock = 0;}
        }
    }
        
        
        }


private int walkcounter = 0;
private int timecounter = 0;
private int xval;
private int xtime;
private int urcounter = 0;
private int ulcounter = 0;
private int olcounter = 0;
private int orcounter = 0;
private int countermax = 200;

// Update:
// appended to organism and makes it move around the map in a 200x200 step area    
    
    void Update()
    {
        //two types of organism prefabs: one has isstatic = 1 and thus doesnt move, the other does
        if (isstatic == 0)
    {
    xval = Random.Range(0, 5);
    xtime = Random.Range(1, 40000);

 // each case is a different direction, case 4 is no movement at all
 // urcounter, ulcounter, orcounter, and olcounter track the steps made in a certain direction
 // When the timecounter is >= the xtime value or the direction steps counter relevant to the case is >= the countermax value:
 // walkcounter is set to a random number, the timecounter is reset, 
 // and on the next iteration the case relevant to the new walkcounter number is opened and that direction is taken.
 // when a direction counter is == countermax, the direction will automatically be changed until a direction is taken that substracts from its counter

    switch(walkcounter)
    {
    case 0:

//sprites are designed to "point" into one direction and are flipped when the direction is changed to give the illusion of naturalist movement
    tierobjekt.GetComponent<SpriteRenderer>().flipX = true;

    if (urcounter < countermax) {transform.Translate(0.5f, -0.5f, 0); timecounter += 1; urcounter +=1; olcounter -=1;}
    else {walkcounter = xval; timecounter = 0;};
    
    if(timecounter >= xtime) {walkcounter = xval; timecounter = 0;};
    break;

    case 1:

    tierobjekt.GetComponent<SpriteRenderer>().flipX = false;

    if (ulcounter < countermax) {transform.Translate(-0.5f, -0.5f, 0); timecounter += 1; ulcounter +=1; orcounter -=1;}
    else {walkcounter = xval; timecounter = 0;};
    
    if(timecounter >= xtime) {walkcounter = xval; timecounter = 0;};
    break;

    case 2:

    tierobjekt.GetComponent<SpriteRenderer>().flipX = false;
    if (olcounter < countermax) {transform.Translate(-0.5f, 0.5f, 0); timecounter += 1; olcounter +=1; urcounter -=1;}
    else {walkcounter = xval; timecounter = 0;};
    
    if(timecounter >= xtime) {walkcounter = xval; timecounter = 0;};
    break;

    case 3:

    tierobjekt.GetComponent<SpriteRenderer>().flipX = true;
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
}
