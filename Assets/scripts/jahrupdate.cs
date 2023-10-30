using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jahrupdate : MonoBehaviour
{
public int paneljahr;
public Image jahrpanel;
public Sprite panelsprite;
public Sprite greypanel;
public int unlock;
public GameObject panel;




public void Update()

{

//year sprite is greyed out depending on if if it is supposed to be unlocked in the selected session

if (main.sitzungsnr >= unlock)
{
    //if (main.sitzungsnr > 0)
    {
    jahrpanel.sprite = panelsprite;
    //jahrpanel.enabled = true;
    }
    
}
else {jahrpanel.sprite = greypanel;}


}


public void jahrupdater()
{

    //when a year is clicked:
    //main year variable is changed to the clicked year
    //year panel is closed
    //scene is reloaded; if the selected year is 2022, the scene is changed into the map with the road
   
   if (main.sitzungsnr >= unlock)
    {
        main.jahr = paneljahr;
        jahrpanel.GetComponent<hidelex>().hideLex(panel);

    if (main.sitzungsnr > 8 )
    {
        if (paneljahr == 18) {newcammove.zoominlimit = 0; newcammove.zoomoutlimit = 0; SceneManager.LoadScene(4);}
        else if (SceneManager.GetActiveScene().buildIndex == 4 && paneljahr < 18)
        {newcammove.zoominlimit = 0; newcammove.zoomoutlimit = 0; SceneManager.LoadScene(1);}
        else {SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}
    }

    else

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    print(main.sitzungsnr);
    print(unlock);
    print(paneljahr);
    print(main.jahr);
    print(main.jahre[main.jahr]);
        
    }

    
}
    
}
