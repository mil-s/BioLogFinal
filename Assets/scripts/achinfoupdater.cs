using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class achinfoupdater : MonoBehaviour
{
    public TMP_Text achinfotext;
    public Image achinfoimage;
    public Sprite lockedsprite;
    public static string achinfoinhalt = "";
    

    public Sprite[] setachsprites;
    public static Sprite[] achsprites;


    //Awake:
    //creates a static sprite array for the infographics
    //by copying the sprites from the sprite gallery that's set by hand in the scene menu


    void Awake()
    {
    achsprites = new Sprite[setachsprites.Length];

    int spritecounter = 0;
    foreach (Sprite item in setachsprites)
    {
      achsprites[spritecounter] = setachsprites[spritecounter];
      spritecounter += 1;
    }
    }

    


    //Update:
    //when the mission info panel is opened, its content are updated to reflect the mission that was clicked to open it.
    //by using the number of the clicked mission stored in currentachievement,
    //info text and the relevant info sprite are taken from their respective galleries/lists.
    //The displayed image depends on if the mission is solved or not,
    //if it is unsolved, the standard question mark graphic is displayed instead


    void Update()
    {
        achinfotext.text = achievements.achievementinfo[achievementverhalten.currentachievement];
        if (achievements.achievementsolved[achievementverhalten.currentachievement] == 1)
        {achinfoimage.sprite = achsprites[achievementverhalten.currentachievement];}
        else {achinfoimage.sprite = lockedsprite;}
    }
}
