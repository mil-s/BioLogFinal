using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mousehover : MonoBehaviour
{
    public Texture2D firstcursor;
    public Texture2D secondcursor;
    public Texture2D altcursor;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public int hovervar;
    public int tierNr;

// old script for handling cursor changes on hover

public void entermouse()
    {

         if (hovervar == 0) {Cursor.SetCursor(firstcursor, hotSpot, cursorMode);}
         else if (hovervar == 1)   {if (main.tierListe[tierNr] == 0) {Cursor.SetCursor(firstcursor, hotSpot, cursorMode);} else {Cursor.SetCursor(altcursor, hotSpot, cursorMode);}}
         else if (hovervar == 2)   {if (main.tierListe[tierNr] == 1) {Cursor.SetCursor(firstcursor, hotSpot, cursorMode);}}
        
    }

public void exitmouse()
    {
        Cursor.SetCursor(secondcursor, Vector2.zero, cursorMode);
    }





}

