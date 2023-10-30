using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;


public class achievements : MonoBehaviour
{


public GameObject achievementprefab;
public GameObject achievpanel;
public static int finishedachievements = 0;

//stores the number of solved missions, the mission info text, and the number of total missions
//by marking any solved/existing mission as 1 in its position in the list
public static List<int> achievementsolved = Enumerable.Repeat(0, 100).ToList();
public static List<string> achievementinfo = Enumerable.Repeat("", 100).ToList();
public static List<int> achievementcounter = Enumerable.Repeat(0, 100).ToList();


// Awake:
// the missions are created at the beginning of the game by calling achievementverhalten()

void Awake()
    {

    achievementverhalten();
    print (achievementinfo[0]);
    print (achievementinfo[1]);

    

    }

void Start()

{
    if (achievpanel.activeSelf){achievpanel.SetActive(false);}
}

// achievementgenerator:
// attributes of the gameobject of each mission are set/updated with this function

public void achievementgenerator(GameObject achievement, string anweisung, string punkte, int nr, string info, string haken)
    {
        achievement.transform.SetParent(GameObject.Find("AllPanels").transform.GetChild(6).transform.GetChild(3).transform.GetChild(0).transform.GetChild(0).transform);
        achievement.transform.GetChild(0).GetComponent<TMP_Text>().text = anweisung;
        achievement.transform.GetChild(1).GetComponent<TMP_Text>().text = punkte;
        achievement.transform.GetChild(3).GetComponent<TMP_Text>().text = haken;
        achievement.GetComponent<achievementverhalten>().achievementnr = nr;
        //achievement.GetComponent<achievementverhalten>().achievement = achievement;
        achievementinfo[nr] = info;
        achievementcounter[nr] = 1;
        

    }


GameObject achievement1;
GameObject achievement2;
GameObject achievement3;

GameObject achievement4;
GameObject achievement5;
GameObject achievement6;

GameObject achievement7;
GameObject achievement8;
GameObject achievement9;

GameObject achievement10;
GameObject achievement11;
GameObject achievement12;



// achievementverhalten: 
// the specific attributes of each individual mission are defined and given to achievementgenerator()
// different misisons are unlocked depending on if the game is group A, B or C

public void achievementverhalten()

    {

        if (main.gruppe == "A" || main.gruppe == "B" || main.gruppe == "C")
        {
        
        achievement1 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement1, "Die Bäume im Wald", "3/3", 0, "Finde die drei Baumarten im Wald. Bestimmte Bäume kann man mit dem Fotoapparat anklicken.", ".");

        achievement2 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement2, "Ein Tier mit Haus", "1/1", 1, "Dieses Tier hat sein eigenes Haus. Kannst du es finden?", ".");

        achievement3 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement3, "Ein besonderes Lebewesen", "1/1", 2, "Finde dieses Lebewesen, das kein Tier und keine Pflanze ist. Es hat einen Hut auf.", ".");

        }
        else {}

        if (main.gruppe == "A" || main.gruppe == "B")
        {
        
        achievement4 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement4, "Ein Ort für Insekten", "2/2", 3, "Finde einen Ort, an dem sich viele fliegende Insekten aufhalten könnten. Finde dort ein grünes Insekt, das noch nicht fliegen kann.", ".");

        achievement6 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement6, "Ein gestreiftes Tier", "1/1", 5, "Dieses geflügelte Tier hat Streifen. Versuche es zu finden.", ".");

        achievement5 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement5, "Eine Entwicklung", "1/1", 4, "Wenn eine Raupe älter wird, sieht sie auf einmal ganz anders aus. Versuche dieses Tier, das auf Nadelbäumen lebt, zu finden.", ".");

        
        
        }
        else {}


        if (main.gruppe == "A" || main.gruppe == "C")
        {

        achievement8 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement8, "Ein gewisser Hügel", "2/2", 7, "Im Wald findet man manchmal braune Hügel. Was hat es damit auf sich? Welche Tiere kann man dort finden?", ".");
        
        achievement7 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement7, "Ein Freund der Ameisen", "1/1", 6, "Es gibt ein Tier, das Pflanzensäfte frisst. Wo könnte man es finden?", ".");

        achievement9 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement9, "Dieses Tier schafft Probleme", "1/1", 8, "Dieses große braune Tier läuft im Wald umher. Kannst du es finden?", ".");
        
        }
        else {}
        

        if (main.gruppe == "B" || main.gruppe == "C")
        {

        achievement11 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement11, "Artenvielfalt", "8/8", 10, "Kannst du 8 Tiere finden?", ".");

        achievement10 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement10, "Lesefreund", "5/5", 9, "Oben links auf dem Bildschirm findest du das Tier-Lexikon. Schau dir 5 Einträge an.", ".");

        achievement12 = (GameObject)Instantiate(achievementprefab);
        achievementgenerator(achievement12, "Schnell wie der Wind", "1/1", 11, "Welches Tier kann wohl besonders schnell rennen?", ".");
        
        }
        else {}

    }


// Update:
// grouped by A, B, C to only check for missions that exist for the specific session
// checks if the mission is solved (value of 1 in its position in the list achievementsolved)
// if 0: 
// updates the mission's counter according to how many requirements are fulfilled (exaple: 2/3 trees found)
// if requirements of the mission are fulfilled: 
// updates mission with completed counter & unveils checkmark (sets haken variable to "")
// updates mission's posiiton in the list achievementsolved to 1
    
    
void Update()

{


    if (main.gruppe == "A" || main.gruppe == "B" || main.gruppe == "C")
    {
    
    // achievement 1


    if (achievementsolved[0] == 0)
    {
    string counter = main.tierListe[15] + main.tierListe[16] + main.tierListe[20] + "/3";
    achievementgenerator(achievement1, "Die Bäume im Wald", counter, 0, "Finde die drei Baumarten im Wald. Bestimmte Bäume kann man mit dem Fotoapparat anklicken.", ".");
    }
    else {}

    if (main.tierListe[15] == 1 && main.tierListe[16] == 1 && main.tierListe[20] == 1)
    {
        string counter = main.tierListe[15] + main.tierListe[16] + main.tierListe[20] + "/3";
        achievementsolved[0] = 1;
        achievementgenerator(achievement1, "Die Bäume im Wald", counter, 0, "Finde die drei Baumarten im Wald. Bestimmte Bäume kann man mit dem Fotoapparat anklicken.", "");
    
    }
    else {}



    // achievement 2

    if (achievementsolved[1] == 0)
    {
    string counter = main.tierListe[12] + "/1";
    achievementgenerator(achievement2, "Ein Tier mit Haus", counter, 1, "Dieses Tier hat ein Haus dabei. Kannst du es finden?", ".");
    }
    else {}

    if (main.tierListe[12] == 1)
    {
        string counter = main.tierListe[12] + "/1";
        achievementsolved[1] = 1;
        achievementgenerator(achievement2, "Ein Tier mit Haus", counter, 1, "Dieses Tier hat ein Haus dabei. Kannst du es finden?", "");
    
    }
    else {}



    // achievement 3

    if (achievementsolved[2] == 0)
    {
    string counter = main.tierListe[21] + "/1";
    achievementgenerator(achievement3, "Ein besonderes Lebewesen", counter, 2, "Finde dieses Lebewesen, das kein Tier und keine Pflanze ist. Es hat einen Hut auf.", ".");
    }
    else {}

    if (main.tierListe[21] == 1)
    {
        string counter = main.tierListe[21] + "/1";
        achievementsolved[2] = 1;
        achievementgenerator(achievement3, "Ein besonderes Lebewesen", "1/1", 2, "Finde dieses Lebewesen, das kein Tier und keine Pflanze ist. Es hat einen Hut auf.", "");
    
    }
    else {}

    }


    if (main.gruppe == "A" || main.gruppe == "B")
    {
    
    // achievement 4

    if (achievementsolved[3] == 0)
    {
    int counternr = gebietsverhalten.bluetencounter + main.tierListe[7];
    string counter = counternr + "/2";
    achievementgenerator(achievement4, "Ein Ort für Insekten", counter, 3, "Finde einen Ort, an dem sich viele fliegende Insekten aufhalten könnten. Finde dort ein grünes Insekt, das noch nicht fliegen kann.", ".");
    }
    else {}

    if (gebietsverhalten.bluetencounter == 1 && main.tierListe[7] == 1)
    {
        int counternr = gebietsverhalten.bluetencounter + main.tierListe[7];
        string counter = counternr + "/2";
        achievementsolved[3] = 1;
        achievementgenerator(achievement4, "Ein Ort für Insekten", counter, 3, "Finde einen Ort, an dem sich viele fliegende Insekten aufhalten könnten. Finde dort ein grünes Insekt, das noch nicht fliegen kann.", "");
    
    }
    else {}


    // achievement 5

    if (achievementsolved[4] == 0)
    {
    string counter = main.tierListe[4] + "/1";
    achievementgenerator(achievement5, "Eine Entwicklung", counter, 4, "Wenn eine Raupe älter wird, sieht sie auf einmal ganz anders aus. Versuche dieses geflügelte Tier zu finden.", ".");
    }
    else {}

    if (main.tierListe[4] == 1)
    {
        string counter = main.tierListe[4] + "/1";
        achievementsolved[4] = 1;
        achievementgenerator(achievement5, "Eine Entwicklung", counter, 4, "Wenn eine Raupe älter wird, sieht sie auf einmal ganz anders aus. Versuche dieses geflügelte Tier zu finden.", "");
    
    }
    else {}


    // achievement 6

     if (achievementsolved[5] == 0)
    {
    string counter = main.tierListe[2] + "/1";
    achievementgenerator(achievement6, "Ein gestreiftes Tier", counter, 5, "Dieses geflügelte Tier hat Streifen. Versuche es zu finden.", ".");
    }
    else {}

    if (main.tierListe[2] == 1)
    {
        string counter = main.tierListe[2] + "/1";
        achievementsolved[5] = 1;
        achievementgenerator(achievement6, "Ein gestreiftes Tier", counter, 5, "Dieses geflügelte Tier hat Streifen. Versuche es zu finden.", "");
    
    }
    else {}


    }
    


    if (main.gruppe == "A" || main.gruppe == "C")
    {
    
    // achievement 7
    
    if (achievementsolved[6] == 0)
    {
    string counter = gebietsverhalten.baumcounter + "/1";
    achievementgenerator(achievement7, "Ein Freund der Ameisen", counter, 6, "Es gibt ein Tier, das Pflanzensäfte frisst. Wo könnte man es finden?", ".");
    }
    else {}

    if (gebietsverhalten.baumcounter == 1)
    {
        string counter = gebietsverhalten.baumcounter + "/1";
        achievementsolved[6] = 1;
        achievementgenerator(achievement7, "Ein Freund der Ameisen", counter, 6, "Es gibt ein Tier, das Pflanzensäfte frisst. Wo könnte man es finden?", "");
    
    }
    else {}


    // achievement 8

    if (achievementsolved[7] == 0)
    {
    int counternr = gebietsverhalten.huegelcounter + main.tierListe[3];
    string counter = counternr + "/2";
    achievementgenerator(achievement8, "Ein gewisser Hügel", counter, 7, "Im Wald findet man manchmal braune Hügel. Was hat es damit auf sich? Welche Tiere kann man dort finden?", ".");
    }
    else {}

    if (gebietsverhalten.huegelcounter == 1 && main.tierListe[3] == 1)
    {
        int counternr = gebietsverhalten.huegelcounter + main.tierListe[3];
        string counter = counternr + "/2";
        achievementsolved[7] = 1;
        achievementgenerator(achievement8, "Ein gewisser Hügel", counter, 7, "Im Wald findet man manchmal braune Hügel. Was hat es damit auf sich? Welche Tiere kann man dort finden?", "");
    
    }
    else {}

    // achievement 9 

    if (achievementsolved[8] == 0)
    {
    string counter = main.tierListe[0] + "/1";
    achievementgenerator(achievement9, "Dieses Tier schafft Probleme", counter, 8, "Dieses große braune Tier läuft im Wald umher. Kannst du es finden?", ".");
    }
    else {}

    if (main.tierListe[0] == 1)
    {
        string counter = main.tierListe[0] + "/1";
        achievementsolved[8] = 1;
        achievementgenerator(achievement9, "Dieses Tier schafft Probleme", counter, 8, "Dieses große braune Tier läuft im Wald umher. Kannst du es finden?", "");
    
    }
    else {}

    }

    
    if (main.gruppe == "B" || main.gruppe == "C")
    {

    // achievement 10
    
     if (achievementsolved[9] == 0)
    {
    string counter = lexclickcounter.clicker + "/5";
    achievementgenerator(achievement10, "Lesefreund", counter, 9, "Oben links auf dem Bildschirm findest du das Tier-Lexikon. Schau dir 5 Einträge an.", ".");
    }
    else {}

    if (lexclickcounter.clicker > 4)
    {
        string counter = "5/5";
        achievementsolved[9] = 1;
        achievementgenerator(achievement10, "Lesefreund", counter, 9, "Oben links auf dem Bildschirm findest du das Tier-Lexikon. Schau dir 5 Einträge an.", "");
    
    }
    else {}

    // achievement 11

    if (achievementsolved[10] == 0)
    {
    string counter = main.tierListe.Sum() + "/8";
    achievementgenerator(achievement11, "Artenvielfalt", counter, 10, "Kannst du 8 Tiere finden?", ".");
    }
    else {}

    if (main.tierListe.Sum() >  7)
    {
        string counter = "8/8";
        achievementsolved[10] = 1;
        achievementgenerator(achievement11, "Artenvielfalt", counter, 10, "Kannst du 8 Tiere finden?", "");
    
    }
    else {}


    // achievement 12


    if (achievementsolved[11] == 0)
    {
    string counter = main.tierListe[14] + "/1";
    achievementgenerator(achievement12, "Schnell wie der Wind", counter, 11, "Welches Tier kann wohl besonders schnell rennen?", ".");

    }

    else {}

    if (main.tierListe[14] == 1)
    {
        string counter = main.tierListe[14] + "/1";
        achievementsolved[11] = 1;
        achievementgenerator(achievement12, "Schnell wie der Wind", counter, 11, "Welches Tier kann wohl besonders schnell rennen?", "");
    
    }
    else {}
    
    
    }

    
    






}



}
