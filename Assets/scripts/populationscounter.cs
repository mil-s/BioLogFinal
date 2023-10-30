using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class populationscounter : MonoBehaviour
{
    
public TMP_Text populationsinfo;
private string populationstext;
public TMP_Text titeltext;
private int popcounter = 0;



public void populationsgenerator()
{

//fills the population panel with info
//if the organism has been unlocked it displays its name and population number
//otherwise "???" is displayed.
//population number is saved in a continuous list for every organism and is calculated as follows:
//(organism number*number of years) + current year + (organism number + 1)

foreach (int i in tiercreate.relevantpop)
{
   
if (main.tierListe[i] == 1)
    {
        populationstext += main.tiernamen[i] + ": \n" + main.populationsliste[((i*((main.jahre.Count)))+main.jahr+(i+1))] + " Exemplare" + "\n" + "\n";
    }

else
    {
        populationstext += "???" + "\n" + "\n";
        
    }

popcounter +=1;
}

//the created strings are fed to the respective text fields and then reset

populationsinfo.text = populationstext;
titeltext.text = "Tiere im Jahr " + main.jahre[main.jahr];

populationstext = "";
popcounter = 0;


}


}
