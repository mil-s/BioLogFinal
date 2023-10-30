using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollbutton : MonoBehaviour
{
    public ScrollRect Scroll;
    public float einheit = 0.5f;

//jumps up and down a scrollrect by a certain amount. made to be used on arrow buttons

    public void scrolldown()
    {
        
        Scroll.verticalNormalizedPosition -= 0.5f;
        //Scroll.value = Mathf.Clamp(Scroll.value - einheit, 0, 1);
    }

    public void scrollup()
    {
        Scroll.verticalNormalizedPosition += 0.5f;
        //Scroll.value = Mathf.Clamp(Scroll.value + einheit, 0, 1);
    }
}
