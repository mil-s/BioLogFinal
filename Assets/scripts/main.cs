using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class main : MonoBehaviour
{

   //main script of the game
   //at the beginning, a lot of variables are set for different aspects of the game

   //missions, organisms and years are each assigned a unique number
   //this unique number is used to access information by being used as a position in a list
   //example: bee has the internal number 2. tierInfo[2] puts out bee information.

   //variabes initialized with 0 keep track of the state of the game such as the current year or session


   public static List<string> tiernamen = Enumerable.Repeat(" ", 100).ToList();
   public static List<string> PDK = Enumerable.Repeat(" ", tiernamen.Count).ToList();
   public static List<int> tierListe = Enumerable.Repeat(0, tiernamen.Count).ToList();
   public static List<string> tierNotizen = Enumerable.Repeat(" ", tiernamen.Count).ToList();
   public static List<string> tierInfo = Enumerable.Repeat(" ", tiernamen.Count).ToList();
   
   public static int jahr = 0;
   public static List<string> jahre = new List<string> {"2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022"};
   public static string username = "no name";
   public static string strsitzungsnr = "leer";
   public static int sitzungsnr = 0;
   public static int camlock = 0;
   public static int lastscene = 0;
   public TMP_InputField userinput;
   public TMP_Text sitzung;
   public GameObject groupwork;

   public Sprite[] seticonsprites;
   public Sprite[] setoverworldsprites;
   public static Sprite[] iconsprites;
   public static Sprite[] overworldsprites;

   public static int scenecounter = 1;

// keeps track of the group A/B/C
   public static string gruppe = "";
   public TMP_Text gruppennr;
   public static int gw = 0;
   

void Awake()

{
   //manually set sprites for the lexicon icons and overworld animals are copied into static arrays 

   iconsprites = new Sprite[seticonsprites.Length];
   overworldsprites = new Sprite[setoverworldsprites.Length];
   
   
    int spritecounter = 0;
    foreach (Sprite item in seticonsprites)
    {
      iconsprites[spritecounter] = seticonsprites[spritecounter];
      spritecounter += 1;
    }


    int owcounter = 0;
    foreach (Sprite item in setoverworldsprites)
    {
      overworldsprites[owcounter] = setoverworldsprites[owcounter];
      owcounter += 1;
    }



}



public static int testvar;
   
//various stuff for testing

public void teststuff () 
{
    print(tierListe[1]);
    testvar +=1; 
    print("hello");
    print(tierInfo[0]);
    print(testvar + " testvar");
    int laenge = jahre.Count;
    print(laenge);


}




   
public void startclick ()

{
//after clicking start, session number/username are saved
//scene is changed into one of the three main forest areas depending on session

strsitzungsnr = sitzung.text;
sitzungsnr = int.Parse(strsitzungsnr);
username = userinput.text.ToString();
//int.TryParse(sitzung, out sitzungsnr);
if (!groupwork.activeSelf)
{
if (sitzungsnr == 1) {swapscene.nextscene(5);}
if (sitzungsnr >= 2 && sitzungsnr < 7  ) { swapscene.nextscene(7);}
if (sitzungsnr >= 7) {swapscene.nextscene(1);}
}

print(username + ", sitzung: " + strsitzungsnr);
print("Sitzung:" + sitzungsnr + "\nGruppe:" + gruppe);

//in the group work version, the group letter is saved and the scene is changed to scene 7
//which path is taken depends on whether the group work interface is visible

if(groupwork.activeSelf)
{
gruppe = gruppennr.text;
swapscene.nextscene(7);
gw = 1;
}

}

//list of values for the laboratory tools
//placeholder values currently

public static List<string> messwerteliste = new List<string> 
   {
    "Die Temperatur in diesem Jahr beträgt:",
    
    "04°C", "05°C", "06°C", "07°C","20°C","20°C","20°C","20°C","20°C","20°C","20°C","20°C","20°C","20°C","20°C","20°C","20°C","20°C","20°C",
    
   "Die Bodenqualität in diesem Jahr beträgt:",

    "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", "boden", 

   "Die Pestizidbelastung in diesem Jahr beträgt:",

   "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", "pestizid", 
    
    "Ende der Liste"
   };

//list that keeps track of which laboratory tools have been used per year
public static List<int> messwerteunlock = new List<int> 
   {
   73, //temperatur
    
   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
    
   80,  //boden

   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 

   93,  //pestizide
   
   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
   
   };

//list of the number of animals per year

public static List<string> populationsliste = new List<string> 
   {
   "Wildschweine pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
    
    "Läuse pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
    
    "Biene pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
    
    "Ameise pro Jahr:",
    "29", "29", "31", "31", "30", "30", "30", "30", "25", "25", "26", "26", "28", "28", "28", "28", "20", "20", "5",
    
    "Kiefernspinner pro Jahr:",
    "50", "50", "70", "70", "80", "80", "60", "60", "40", "40", "20", "20", "45", "45", "60", "60", "20", "20", "40",
    
    "Specht pro Jahr:",
    "60", "60", "55", "55", "45", "45", "40", "40", "48", "48", "55", "55", "60", "60", "50", "50", "45", "45", "30",
    
    "Marienkaefer pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
   
    "Raupe pro Jahr:",
    "9", "9", "10", "10", "8", "8", "7", "7", "5", "5", "6", "6", "7", "7", "9", "9", "6", "6", "70",
    
    "Assel pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
   
    "Wurm pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
   
    "Borkenkäfer pro Jahr:",
    "32", "32", "30", "30", "44", "44", "54", "54", "69", "69", "59", "59", "41", "41", "32", "32", "35", "35", "19",
   
    "Igel pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
   
    "Schnecke pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
   
    "Fuchs pro Jahr:",
    "8", "8", "10", "10", "7", "7", "4", "4", "3", "3", "12", "12", "21", "21", "16", "16", "8", "8", "12",
   
    "Hase pro Jahr:",
    "36", "36", "27", "27", "5", "5", "2", "2", "20", "20", "38", "38", "8", "8", "5", "5", "9", "9", "20",
   
    "Fichte pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
    
    "Kiefer pro Jahr:",
    "98", "98", "98", "98", "80", "80", "80", "80", "79", "79", "99", "99", "99", "99", "99", "99", "98", "98", "20",
    
    "Leberblümchen pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
    
    "Besenginster pro Jahr:",
    "87", "87", "85", "85", "95", "95", "96", "96", "97", "97", "80", "80", "75", "75", "80", "80", "85", "85", "15",
    
    "Enzian pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
    
    "Eiche pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
    
    "Pilze pro Jahr:",
    "94", "23", "34", "24", "26", "26", "24", "24", "36", "36", "36", "36", "43", "43", "36", "36", "36", "24", "26",
    
    "Ende der Liste"
    };





string tierListeSp;
string tierNotizenSp;
string messunlockSp;


//SaveGame:
//function that saves all unlocked animals, laboratory tool uses, and custom notes
//contents of the respective lists are saved in one long string divided by <_> for easy parsing
//worked in testing but is not used in current game. requested feature for the future

public void SaveGame()
{

foreach (int i in tierListe)
{tierListeSp += i.ToString() + "<_>";}

foreach (int i in messwerteunlock)
{messunlockSp += i.ToString() + "<_>";}

foreach (string i in tierNotizen)
{tierNotizenSp += i + "<_>";}

//removes the last <_> from the strings to fix an error and saves the variables as playerprefs

	PlayerPrefs.SetString("tierListe", tierListeSp.Substring(0, tierListeSp.Length - 3));
   PlayerPrefs.SetString("messwerteunlock", messunlockSp.Substring(0, messunlockSp.Length - 3));
   PlayerPrefs.SetString("tierNotizen", tierNotizenSp.Substring(0, tierNotizenSp.Length - 3));
	PlayerPrefs.SetInt("jahr", jahr);
   //PlayerPrefs.SetInt("achievement1", achievements.achievement1unlock);
	
	PlayerPrefs.Save();
}

//LoadGame:
//loads up the saved variables from the playerprefs
//parses the saved strings and splits them back into the list values at <_>. updates the newly created lists with the saved values
//sister function to SaveGame and thus not used in the current game.

public void LoadGame()
{

tierNotizenSp = PlayerPrefs.GetString("tierNotizen");
tierListeSp = PlayerPrefs.GetString("tierListe");
messunlockSp = PlayerPrefs.GetString("messwerteunlock");
jahr = PlayerPrefs.GetInt("jahr");
//achievements.achievement1unlock = PlayerPrefs.GetInt("achievement1");


string[] notearray;
int notecounter = 0;
notearray = tierNotizenSp.Split("<_>");
foreach (string item in notearray)
{
   tierNotizen[notecounter] = item;
   notecounter +=1;
}

string[] unlockarray;
int unlockcounter = 0;
unlockarray = tierListeSp.Split("<_>");
foreach (string item in unlockarray)
{
   tierListe[unlockcounter] = int.Parse(item);
   unlockcounter +=1;
}

string[] messarray;
int messcounter = 0;
messarray = messunlockSp.Split("<_>");
foreach (string item in messarray)
{
   messwerteunlock[unlockcounter] = int.Parse(item);
   messcounter +=1;
}


}





}




