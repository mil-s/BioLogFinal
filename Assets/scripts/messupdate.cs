using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class messupdate : MonoBehaviour
{
public Image messpanel;
public Sprite messsprite;
public Sprite startsprite;
public TMP_Text messtext;
public TMP_Text messinfo;

public int messgeraet;

//this script handles the laboratory tools. They are tools that measure different values and can be clicked once for every ingame year
//to display different values. the game keeps track of which years you used the tools in

public void jahrupdater()

//if the tool is clicked: 
//the unlock value of the tool during the respective ingame year is changed to 1
//the text on the info panel that pops up changes to the respective value during that year
//as both unlock status and laboratory values are saved in continuous lists, the needed list position is calculated as follows:
//(number of the tool * number of years) + current year + (number of tool + 1)

{
        {
            main.messwerteunlock[((messgeraet*((main.jahre.Count)))+main.jahr+(messgeraet+1))] = 1;
           
            messinfo.text = main.messwerteliste[((messgeraet*((main.jahre.Count)))+main.jahr+(messgeraet+1))];

        }
}


void Update()
    
    //if the tool has been used in that year (unlock = 1):
    //sprite of the tool changes to a paler version
    //laboratory value is displayed permanently ontop of the paler sprite
    
    {
       if (main.messwerteunlock[((messgeraet*((main.jahre.Count)))+main.jahr+(messgeraet+1))] == 1)
       {
         messpanel.sprite = messsprite;
         messtext.text = main.messwerteliste[((messgeraet*((main.jahre.Count)))+main.jahr+(messgeraet+1))];
       }
       else 
       {
        messpanel.sprite = startsprite;
        messtext.text = "";
       }
       
    }




}
