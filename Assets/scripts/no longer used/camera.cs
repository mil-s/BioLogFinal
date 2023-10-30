using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour
{

//old camera script that was based on arrow buttons


private Vector3 cursorpos;

[SerializeField]
private Camera thecamera;

public Button Button1;
public Button Button2;
private static int upcounter = 1;
private static int rightcounter = 1;
private static Vector3 newposition;
private static Vector3 camposition;
private static int ctrlvar = 1;


public void Start()

{
    if (ctrlvar == 1)
   {
    camposition = thecamera.transform.position;
    newposition = thecamera.transform.position;
    ctrlvar -=1;
    }
    
}

public void cameramoveup()
{
if (upcounter == 1)
{
camposition = thecamera.transform.position;
newposition.y = newposition.y + 2*thecamera.orthographicSize;
Button1.interactable = false;
Button2.interactable = true;
upcounter -= 1;
}
}

public void cameramovedown()
{
if (upcounter == 0)
{
camposition = thecamera.transform.position;
newposition.y = newposition.y - 2*thecamera.orthographicSize;
Button1.interactable = false;
Button2.interactable = true;
upcounter += 1;
}
}

public void cameramoveright()
{
if (rightcounter == 1)
{
camposition = thecamera.transform.position;
newposition.x = newposition.x + 2*thecamera.orthographicSize*thecamera.aspect;
Button1.interactable = false;
Button2.interactable = true;
rightcounter -= 1;
}
}

public void cameramoveleft()
{
if (rightcounter == 0)
{
camposition = thecamera.transform.position;
newposition.x = newposition.x - 2*thecamera.orthographicSize*thecamera.aspect;
Button1.interactable = false;
Button2.interactable = true;
rightcounter += 1;
}
}



public void Update()

{
    thecamera.transform.position = Vector3.Lerp(camposition, newposition, 0.015f);
    camposition = thecamera.transform.position;
}



}