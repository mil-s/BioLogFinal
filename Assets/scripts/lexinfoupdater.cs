using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lexinfoupdater : MonoBehaviour
{

public TMP_Text lexinfotext;
public Image lexinfoimage;
public TMP_Text notizenfeld;
public TMP_Text lextiername;
public Image prod;
public Image dest;
public Image kons;
public Image dest2;

//this script handles the panel that displays organism information when the organism's icon in the lexicon is clicked
//through the value currentTier, the needed information on the currently clicked organism is taken from various lists and displayed
//1-2 of 4 graphics representing positions in the cycle of matter are shown or hidden depending on which the organism belongs to

    void Update()
    {

        lexinfoimage.sprite = main.iconsprites[tierverhalten2.currentTier];
        lexinfotext.text = main.tierInfo[tierverhalten2.currentTier];
        notizenfeld.text = main.tierNotizen[tierverhalten2.currentTier];
        lextiername.text = main.tiernamen[tierverhalten2.currentTier];

        print(main.tiernamen[tierverhalten2.currentTier]);

        if (main.PDK[tierverhalten2.currentTier] == "p")
        {
            prod.enabled = true;
            dest.enabled = false;
            kons.enabled = false;
            dest2.enabled = false;
        }

        else if (main.PDK[tierverhalten2.currentTier] == "d")
        {
            prod.enabled = false;
            dest.enabled = true;
            kons.enabled = false;
            dest2.enabled = false;
        }

        else if (main.PDK[tierverhalten2.currentTier] == "k")
        {
            prod.enabled = false;
            dest.enabled = false;
            kons.enabled = true;
            dest2.enabled = false;

        }

        else if (main.PDK[tierverhalten2.currentTier] == "kd")
        {
            prod.enabled = false;
            dest.enabled = false;
            kons.enabled = true;
            dest2.enabled = true;
        }



        
    }
}
