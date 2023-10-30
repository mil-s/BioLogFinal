using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class toolssitzung : MonoBehaviour
{

    //public GameObject tool;
    //public int sitzung;
    public GameObject messhalter;
    public GameObject pop;
    public GameObject mess;

    //activates tools based on session

    void Awake()
    {
        if (main.sitzungsnr < 5) {messhalter.SetActive(false);} else {}
        
        if (main.sitzungsnr < 5) {pop.GetComponent<Button>().interactable = false;} else {}

        if (main.sitzungsnr < 7) {mess.GetComponent<Button>().interactable = false;} else {}
    }

}
