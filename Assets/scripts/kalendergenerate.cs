using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class kalendergenerate : MonoBehaviour
{
    public GameObject kalenderprefab;

    //this script handles the calendar objects displayed in the panel that appears when the calendar button is clicked
    //functions analogous to the missions panel creation scripts

   
    void Awake()
    {
        //objects are created when the game is started

        kalenderverhalten();
    }

    //kalendergenerator:
    //the attributes and visuals of the year objects are assigned
    //every year gets its unique number, as well as a variable for the session at which it is unlocked

    public void kalendergenerator(GameObject kalender, int paneljahr, int unlock)
    {
        kalender.transform.SetParent(GameObject.Find("kalenderblatt").transform.GetChild(0).transform.GetChild(0));
        kalender.transform.GetChild(0).GetComponent<TMP_Text>().text = main.jahre[paneljahr];
        //kalender.transform.GetChild(0).GetComponent<TMP_Text>().text = unlock.ToString();
        kalender.GetComponent<jahrupdate>().paneljahr = paneljahr;
        kalender.GetComponent<jahrupdate>().unlock = unlock;
        kalender.GetComponent<jahrupdate>().panel = GameObject.Find("kalenderblatt");
        kalender.GetComponent<jahrupdate>().jahrpanel = kalender.GetComponent<Image>();

        

    }

    GameObject jahr2004;

    GameObject jahr2005;

    GameObject jahr2006;

    GameObject jahr2007;

    GameObject jahr2008;

    GameObject jahr2009;

    GameObject jahr2010;

    GameObject jahr2011;

    GameObject jahr2012;

    GameObject jahr2013;

    GameObject jahr2014;

    GameObject jahr2015;

    GameObject jahr2016;

    GameObject jahr2017;

    GameObject jahr2018;

    GameObject jahr2019;

    GameObject jahr2020;

    GameObject jahr2021;

    GameObject jahr2022;


    public void kalenderverhalten()

    {

    //year objects with attributes are created

        jahr2004 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2004, 0, 0);
        

        jahr2005 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2005, 1, 6);

        jahr2006 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2006, 2, 6);

        jahr2007 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2007, 3, 6);

        jahr2008 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2008, 4, 6);

        jahr2009 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2009, 5, 6);

        jahr2010 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2010, 6, 6);

        jahr2011 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2011, 7, 6);

        jahr2012 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2012, 8, 6);

        jahr2013 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2013, 9, 6);

        jahr2014 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2014, 10, 6);

        jahr2015 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2015, 11, 6);

        jahr2016 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2016, 12, 6);

        jahr2017 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2017, 13, 6);

        jahr2018 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2018, 14, 6);

        jahr2019 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2019, 15, 6);

        jahr2020 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2020, 16, 6);

        jahr2021 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2021, 17, 9);

        jahr2022 = (GameObject)Instantiate(kalenderprefab);
        kalendergenerator(jahr2022, 18, 9);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
