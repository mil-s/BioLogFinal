using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class kalender : MonoBehaviour
{

public TMP_Text kalenderblatt;

//calendar button displays the current year, whose display text is taken from the list of years
    
    void Update()
    {
        kalenderblatt.text = main.jahre[main.jahr];
    }

    
}
