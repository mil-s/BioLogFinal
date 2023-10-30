using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hidelex : MonoBehaviour
{

    public void hideLex(GameObject lex)
    
        {

            //on click, an object is hidden or unveiled, depending on its current state
            //camera is locked if the object was made visible
            
            lex.gameObject.SetActive(!lex.gameObject.activeSelf);

            //if (main.camlock == 0) {main.camlock = 1;}
            if (lex.activeSelf) {main.camlock = 1;}
            else {main.camlock = 0;}

        }


public void closeLex(GameObject lex)
    
        {
            //function to definitely hide an object
            
            lex.gameObject.SetActive(false);
            

        }
        
        
        

}
