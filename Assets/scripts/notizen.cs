using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class notizen : MonoBehaviour
{

public TMP_Text notizenfeld;
public TMP_InputField notizeninput;
public static int notizenvariable;
public static int edited = 1;

public void notizensave()

//custom player notes are saved in the player notes list in the main script
//the notes display field is updated to reflect the new contents

{
    main.tierNotizen[notizenvariable] = notizeninput.text.ToString();
    notizenfeld.text = main.tierNotizen[notizenvariable];
    edited = 1;
    
}

public void Update()

//when the player wants to edit their notes, the saved notes are copied into the input field
//so the player can edit them

{
//notizenfeld.text = main.tierNotizen[notizenvariable];

if (edited == 1)
{notizeninput.text = notizenfeld.text; edited = 0;}
}

}
