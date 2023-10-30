using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class tiercreate : MonoBehaviour
{

public GameObject tierprefab;
public GameObject plantprefab;
public GameObject lexprefab;




    void Start()
    {
        tiererstellung();
    }

//setvalues:
//sets the attributes of the organism objects (number, name, sprite, info, matter cycle, position)

    public void setvalues(GameObject tier, int tierNr, string tierName, string tierInfo, string PDK)
    {
        tier.GetComponent<tierverhalten2>().tierNr = tierNr;
        tier.GetComponent<tierverhalten2>().tierobjekt = tier;
        Debug.Log(main.overworldsprites[tierNr].name);
        tier.GetComponent<SpriteRenderer>().sprite = main.overworldsprites[tierNr];
        main.tiernamen[tierNr] = tierName;
        main.tierInfo[tierNr] = tierInfo;
        main.PDK[tierNr] = PDK;
        tier.transform.localScale = new Vector3(0,0,0);

    }

    public void setlexer(GameObject lex, int tierNr)
    {

    // sets attributes and parents the lexicon icon objects

        lex.transform.SetParent(GameObject.Find("AllPanels").transform.GetChild(3).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0));

        lex.GetComponent<lexupdater>().tierNr = tierNr;
        lex.GetComponent<lexupdater>().leximagebutton = lex;
        lex.GetComponent<lexupdater>().leximage = lex.GetComponent<Image>();
        
        

    }

   

private GameObject boar;
private GameObject boarlex;
private GameObject laus;
private GameObject lauslex;
private GameObject bee;
private GameObject beelex;
private GameObject ant;
private GameObject antlex;
private GameObject kiefernspinner;
private GameObject kiefernspinnerlex;
private GameObject specht;
private GameObject spechtlex;
private GameObject marienkaefer;
private GameObject marienkaeferlex;
private GameObject raupe;
private GameObject raupenlex;
private GameObject assel;
private GameObject assellex;
private GameObject wurm;
private GameObject wurmlex;
private GameObject borkenkaef;
private GameObject borkenkaeflex;
private GameObject igel;
private GameObject igellex;
private GameObject schnecke;
private GameObject schneckelex;
private GameObject fuchs;
private GameObject fuchslex;
private GameObject hase;
private GameObject haselex;
private GameObject eiche;
private GameObject eichelex;
private GameObject fichte;
private GameObject fichtelex;
private GameObject kiefer;
private GameObject kieferlex;
private GameObject leber;
private GameObject leberlex;
private GameObject besen;
private GameObject besenlex;
private GameObject enzian;
private GameObject enzianlex;
private GameObject pilz;
private GameObject pilzlex;


//list of the organisms that are displayed in the population panel
public static List<int> relevantpop = new List<int> {1, 3, 4, 5, 10, 13, 14, 16, 18};



    void tiererstellung()

    {
        //creates the organisms and their lexicon icons

        boar = (GameObject)Instantiate(tierprefab);
        setvalues(boar, 0, "Wildschwein", "Das Wildschwein (Sus scrofa), jaegersprachlich Schwarzwild genannt, ist ein Paarhufer in der Familie der Echten Schweine und die Stammform des Hausschweins.", "k" );
        boar.transform.position = new Vector3(-585486573, -45654734, -3457534);

        boarlex = (GameObject)Instantiate(lexprefab);
        setlexer(boarlex, 0);
        
        laus = (GameObject)Instantiate(tierprefab);
        setvalues(laus, 1, "Blattlaus", "Blattläuse sind kleine Insekten, die auf Pflanzen leben. \nErnährung: Sie fressen Pflanzensäfte, die sie mit Rüsseln aus den Blättern saugen. \nLebensraum: Blätter.", "k" );
        laus.transform.position = new Vector3(-585486573, -45654734, -3457534);

        lauslex = (GameObject)Instantiate(lexprefab);
        setlexer(lauslex, 1);

        bee = (GameObject)Instantiate(tierprefab);
        setvalues(bee, 2, "Biene", "Honigbienen sind Insekten, die in großen Gruppen zusammen leben und stark zusammenarbeiten. \nErnährung: Sie fressen Nektar und Pollen von Blumen.\nLebensraum: Sie bauen meist große Nester und machen dort Honig.", "k");
        bee.transform.position = new Vector3(-585486573, -45654734, -3457534);

        beelex = (GameObject)Instantiate(lexprefab);
        setlexer(beelex, 2);

        ant = (GameObject)Instantiate(tierprefab);
        setvalues(ant, 3, "Rote Waldameise", "Die Waldameisen sind ein Insekt, sie leben in großen Gemeinschaften zusammen.\nErnährung: Sie fressen hauptsächlich Honigtau (wird von Blattläusen abgegeben), Insekten und Samen.\nLebensraum: Sie bauen gemeinsam große unterirdische Nester.", "kd");
        ant.transform.position = new Vector3(-585486573, -45654734, -3457534);

        antlex = (GameObject)Instantiate(lexprefab);
        setlexer(antlex, 3);

        raupe = (GameObject)Instantiate(tierprefab);
        setvalues(raupe, 7, "Raupe", "Der Kiefernspinner ist ein Schmetterling. Er entwickelt sich von einer Raupe zu einem Falter.\nErnährung & Lebensraum: Die Raupen leben auf Kiefern und fressen Kiefernnadeln.", "k");
        raupe.transform.position = new Vector3(-585486573, -45654734, -3457534);

        raupenlex = (GameObject)Instantiate(lexprefab);
        setlexer(raupenlex, 7);

        kiefernspinner = (GameObject)Instantiate(tierprefab);
        setvalues(kiefernspinner, 4, "Kiefernspinner", "Der Kiefernspinner ist ein Schmetterling. Er entwickelt sich von einer Raupe zu einem Falter.", "k");
        kiefernspinner.transform.position = new Vector3(-585486573, -45654734, -3457534);

        kiefernspinnerlex = (GameObject)Instantiate(lexprefab);
        setlexer(kiefernspinnerlex, 4);

        specht = (GameObject)Instantiate(tierprefab);
        setvalues(specht, 5, "Specht", "Der Grünspecht ist ein Vogel. Er klopft mit seinem Schnabel lautstark auf Bäume, um die Insekten in der Baumrinde zu erreichen.\nErnährung: Er frisst Insekten, besonders Ameisen.\nLebensraum: Wald.", "k");
        specht.transform.position = new Vector3(-585486573, -45654734, -3457534);

        spechtlex = (GameObject)Instantiate(lexprefab);
        setlexer(spechtlex, 5);

        marienkaefer = (GameObject)Instantiate(tierprefab);
        setvalues(marienkaefer, 6, "Marienkäfer", "Marienkäfer sind kleine rote Käfer. Sie entwickeln sich von einem Ei zu einer Larve und schließlich zu einem Käfer.\nErnährung: Sie fressen gerne Blattläuse.\nLebensraum: Sie leben in Wälder, Wiesen und Mooren.", "k");
        marienkaefer.transform.position = new Vector3(-585486573, -45654734, -3457534);

        marienkaeferlex = (GameObject)Instantiate(lexprefab);
        setlexer(marienkaeferlex, 6);

        assel = (GameObject)Instantiate(tierprefab);
        setvalues(assel, 8, "Assel", "Landasseln sind Krebstiere.\nErnährung: Sie fressen tote Pflanzenteile, tote Insekten und Kot.\nLebensräume: Man findet sie häufig unter Steinen.", "d");
        assel.transform.position = new Vector3(-585486573, -45654734, -3457534);

        assellex = (GameObject)Instantiate(lexprefab);
        setlexer(assellex, 8);

        wurm = (GameObject)Instantiate(tierprefab);
        setvalues(wurm, 9, "Wurm", "Regenwürmer sind Würmer, die in der Erde Leben. Sie können teile ihres Körpers neu wachsen lassen, wenn sie verletzt werden.\nErnährung: Tote Pflanzenteile und Erde.", "d");
        wurm.transform.position = new Vector3(-585486573, -45654734, -3457534);

        wurmlex = (GameObject)Instantiate(lexprefab);
        setlexer(wurmlex, 9);

        borkenkaef = (GameObject)Instantiate(tierprefab);
        setvalues(borkenkaef, 10, "Borkenkäfer", "Borkenkäfer gehören zu den Rüsselkäfern.\nErnährung: Baumrinde und Holz.\nLebensraum: Sie leben auf Bäumen und in Baumrinde.", "kd");
        borkenkaef.transform.position = new Vector3(-585486573, -45654734, -3457534);

        borkenkaeflex = (GameObject)Instantiate(lexprefab);
        setlexer(borkenkaeflex, 10);

        igel = (GameObject)Instantiate(tierprefab);
        setvalues(igel, 11, "Igel", "Der Igel ist ein Säugetier. Um sich vor Feinden zu schützen hat er Stacheln und kann sich zu einer Kugel zusammen Rollen.\nErnährung: Sie fressen Insekten, Würmer und Schnecken.\nLebensraum: Sie leben in Wäldern und Wiesen.", "k");
        igel.transform.position = new Vector3(-585486573, -45654734, -3457534);

        igellex = (GameObject)Instantiate(lexprefab);
        setlexer(igellex, 11);

        schnecke = (GameObject)Instantiate(tierprefab);
        setvalues(schnecke, 12, "Schnecke", "Die Weinbergschnecke ist eine Landschnecke mit Schneckenhaus. Sie bildet einen Schneckenschleim durch den sie sich besser fortbewegen kann.\nErnährung: Sie fressen welke Blätter.\nLebensraum: Sie lebt in Wäldern", "kd");
        schnecke.transform.position = new Vector3(-585486573, -45654734, -3457534);

        schneckelex = (GameObject)Instantiate(lexprefab);
        setlexer(schneckelex, 12);

        fuchs = (GameObject)Instantiate(tierprefab);
        setvalues(fuchs, 13, "Fuchs", "Rotfüchse sind Säugetiere. Sie sind mit den Hunden verwandt.\nErnährung: Der Fuchs ist ein Allesfresser. Er frisst zum Beispiel Mäuse, Würmer, Hasen und Früchte.\nLebensraum: Er lebt in Wäldern und Grasland und wohnt in einem Fuchsbau.", "k");
        fuchs.transform.position = new Vector3(-585486573, -45654734, -3457534);

        fuchslex = (GameObject)Instantiate(lexprefab);
        setlexer(fuchslex, 13);

        hase = (GameObject)Instantiate(tierprefab);
        setvalues(hase, 14, "Hase", "Der Feldhase ist ein Säugetier. Er ist Nachtaktiv.\nErnährung: Pflanzen.\nLebensraum: Wiesen, Felder, Wald.", "k");
        hase.transform.position = new Vector3(-585486573, -45654734, -3457534);

        haselex = (GameObject)Instantiate(lexprefab);
        setlexer(haselex, 14);

        fichte = (GameObject)Instantiate(plantprefab);
        setvalues(fichte, 15, "Fichte", "Fichten sind Nadelbäume. Sie bilden Zapfen, welche die Samen enthalten.", "p");
        fichte.transform.position = new Vector3(-585486573, -45654734, -3457534);

        fichtelex = (GameObject)Instantiate(lexprefab);
        setlexer(fichtelex, 15);

        kiefer = (GameObject)Instantiate(plantprefab);
        setvalues(kiefer, 16, "Kiefer", "Kiefern sind Nadelbäume. Sie bilden Zapfen, welche die Samen enthalten.", "p");
        kiefer.transform.position = new Vector3(-585486573, -45654734, -3457534);

        kieferlex = (GameObject)Instantiate(lexprefab);
        setlexer(kieferlex, 16);

        leber = (GameObject)Instantiate(plantprefab);
        setvalues(leber, 17, "Leberblümchen", "Leberblümchen sind Blumen mit lila Blüten. Sie produzieren Pollen, der von Bienen und Käfern gefressen wird.", "p");
        leber.transform.position = new Vector3(-585486573, -45654734, -3457534);

        leberlex = (GameObject)Instantiate(lexprefab);
        setlexer(leberlex, 17);

        besen = (GameObject)Instantiate(plantprefab);
        setvalues(besen, 18, "Besenginster", "Der Besenginster ist ein Strauch mit gelben Blüten. Er wächst häufig in Wäldern.", "p");
        besen.transform.position = new Vector3(-585486573, -45654734, -3457534);

        besenlex = (GameObject)Instantiate(lexprefab);
        setlexer(besenlex, 18);

        enzian = (GameObject)Instantiate(plantprefab);
        setvalues(enzian, 19, "Enzian", "Enzian ist eine Pflanze mit gelben oder blauen Blüten. Erwächst vor allem in den Bergen.", "p");
        enzian.transform.position = new Vector3(-585486573, -45654734, -3457534);

        enzianlex = (GameObject)Instantiate(lexprefab);
        setlexer(enzianlex, 19);

        eiche = (GameObject)Instantiate(plantprefab);
        setvalues(eiche, 20, "Eiche", "Eichen sind Laubbäume, die groß und sehr alt werden können. Die Frucht der Eiche ist die Eichel. ", "p");
        eiche.transform.position = new Vector3(-585486573, -45654734, -3457534);

        eichelex = (GameObject)Instantiate(lexprefab);
        setlexer(eichelex, 20);

        pilz = (GameObject)Instantiate(plantprefab);
        setvalues(pilz, 21, "Pilz", "Der kleine Waldchampignon ist ein Pilz. Pilze sind keine Tieren und auch keine Pflanzen, sie bilden eine eigene Gruppe.\nErnährung: Er ernährt sich von totem Pflanzenmaterial.\nLebensraum: Er wächst auf dem Waldboden.", "d");
        pilz.transform.position = new Vector3(-585486573, -45654734, -3457534);
        
        pilzlex = (GameObject)Instantiate(lexprefab);
        setlexer(pilzlex, 21);

// spawns the organisms into the scenes with specific sizes and numbers

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            //wald

            //future plans: change organisms and numbers etc. depending on sessions
            spawner.spawnerfunction(boar, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 70f, 100f);
            spawner.spawnerfunction(fuchs, GameObject.Find("waldspawn1"), 1, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(hase, GameObject.Find("waldspawn1"), 3, "umgebungCanvas", 30f, 40f);
            spawner.spawnerfunction(igel, GameObject.Find("waldspawn1"), 2, "umgebungCanvas", 20f, 30f);
            spawner.spawnerfunction(igel, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 20f, 30f);
            spawner.spawnerfunction(besen, GameObject.Find("waldspawn1"), 3, "umgebungCanvas", 40f, 50f);
            spawner.spawnerfunction(besen, GameObject.Find("waldspawn2"), 2, "umgebungCanvas", 40f, 50f);
            //spawner.spawnerfunction(bee, GameObject.Find("waldspawn1"), 3, "umgebungCanvas", 5f, 10f);

            spawner.spawnerfunction(kiefer, GameObject.Find("waldspawn1"), 3, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(fichte, GameObject.Find("waldspawn1"), 4, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(eiche, GameObject.Find("waldspawn1"), 3, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(kiefer, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(fichte, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(eiche, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 50f, 70f);
        
        }

        // wald sess 1

        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            
            spawner.spawnerfunction(kiefer, GameObject.Find("lichtungarea"), 3, "umgebungCanvas", 50f, 70f);
            //spawner.spawnerfunction(schnecke, GameObject.Find("lichtungarea"), 3, "umgebungCanvas", 30f, 40f);
        
        }
        
        //wald sess 2

        if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            
            spawner.spawnerfunction(boar, GameObject.Find("waldspawn1"), 1, "umgebungCanvas", 70f, 100f);
            spawner.spawnerfunction(fuchs, GameObject.Find("waldspawn1"), 1, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(hase, GameObject.Find("waldspawn1"), 2, "umgebungCanvas", 30f, 40f);
            spawner.spawnerfunction(igel, GameObject.Find("waldspawn1"), 2, "umgebungCanvas", 20f, 30f);
            spawner.spawnerfunction(besen, GameObject.Find("waldspawn1"), 3, "umgebungCanvas", 40f, 50f);
            //spawner.spawnerfunction(besen, GameObject.Find("waldspawn2"), 2, "umgebungCanvas", 40f, 50f);
            //spawner.spawnerfunction(igel, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 20f, 30f);
            //spawner.spawnerfunction(bee, GameObject.Find("waldspawn1"), 3, "umgebungCanvas", 5f, 10f);

            spawner.spawnerfunction(kiefer, GameObject.Find("waldspawn1"), 3, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(fichte, GameObject.Find("waldspawn1"), 4, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(eiche, GameObject.Find("waldspawn1"), 3, "umgebungCanvas", 50f, 70f);
        }

        // 2022 map

        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            //spawner.spawnerfunction(boar, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 70f, 100f);
            spawner.spawnerfunction(fuchs, GameObject.Find("waldspawn1b"), 1, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(hase, GameObject.Find("waldspawn1a"), 1, "umgebungCanvas", 30f, 40f);
            //spawner.spawnerfunction(igel, GameObject.Find("waldspawn1"), 2, "umgebungCanvas", 20f, 30f);
            spawner.spawnerfunction(igel, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 20f, 30f);
            spawner.spawnerfunction(besen, GameObject.Find("waldspawn1a"), 1, "umgebungCanvas", 40f, 50f);
            spawner.spawnerfunction(besen, GameObject.Find("waldspawn1b"), 1, "umgebungCanvas", 40f, 50f);

            spawner.spawnerfunction(kiefer, GameObject.Find("waldspawn1a"), 1, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(fichte, GameObject.Find("waldspawn1b"), 1, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(eiche, GameObject.Find("waldspawn1a"), 1, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(kiefer, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(fichte, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 50f, 70f);
            spawner.spawnerfunction(eiche, GameObject.Find("waldspawn2"), 1, "umgebungCanvas", 50f, 70f);
        }

        //zoom areas


        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            spawner.spawnerfunction(laus, GameObject.Find("umgebung"), Random.Range(8, 15) , "umgebungCanvas", -10f, -20f);
        }

        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            spawner.spawnerfunction(ant, GameObject.Find("ameisenspawn"), Random.Range(5, 9), "umgebungCanvas", -10f, -20f);
            if (main.sitzungsnr > 2)
            {
                spawner.spawnerfunction(schnecke, GameObject.Find("schneckenspawn"), 1, "umgebungCanvas", 20f, 30f);
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            spawner.spawnerfunction(kiefernspinner, GameObject.Find("umgebung"), Random.Range(4, 8), "umgebungCanvas", -10f, -20f);
            spawner.spawnerfunction(borkenkaef, GameObject.Find("umgebung"), Random.Range(1, 3), "umgebungCanvas", -10f, -20f);
        }

        if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            spawner.spawnerfunction(bee, GameObject.Find("bienenspawn"), 3, "umgebungCanvas", 5f, 10f);
            spawner.spawnerfunction(raupe, GameObject.Find("raupenspawn"), 3, "umgebungCanvas", 5f, 10f);
            spawner.spawnerfunction(marienkaefer, GameObject.Find("mkspawn"), 4, "umgebungCanvas", 5f, 10f);
            spawner.spawnerfunction(leber, GameObject.Find("raupenspawn"), 2, "umgebungCanvas", 20f, 30f);
            spawner.spawnerfunction(enzian, GameObject.Find("bienenspawn"), 2, "umgebungCanvas", 20f, 40f);
        }

        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            spawner.spawnerfunction(assel, GameObject.Find("linksspawn"), Random.Range(5, 10), "umgebungCanvas", 10f, 20f);
            spawner.spawnerfunction(wurm, GameObject.Find("rechtsspawn"), Random.Range(1, 3), "umgebungCanvas", 40f, 50f);
            spawner.spawnerfunction(pilz, GameObject.Find("umgebung"), Random.Range(3, 6), "umgebungCanvas", 70f, 80f);
            spawner.spawnerfunction(schnecke, GameObject.Find("umgebung"), Random.Range(1, 3), "umgebungCanvas", 30f, 45f);
            
        }

        


    }







}
