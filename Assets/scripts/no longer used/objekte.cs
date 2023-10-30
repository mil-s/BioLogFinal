using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objekte : MonoBehaviour
{

public class animal
{
    public int tiernr;
    public string name;
    public string tierinfo;

    public animal(int tiernr, string name, string tierinfo)
    {
        this.tiernr = tiernr;
        this.name = name;
        this.tierinfo = tierinfo;
    }
}

// old object organization design

public List<animal> animalList = new List<animal>();

void Start()

{
    animal wildschwein = new animal
    (
    0,
    "wildschwein",
    "Das Wildschwein (Sus scrofa), jaegersprachlich Schwarzwild genannt, ist ein Paarhufer in der Familie der Echten Schweine und die Stammform des Hausschweins.[1] Das ursprüngliche Verbreitungsgebiet reicht von Westeuropa bis Südostasien. Durch Aussetzen in Nord- und Südamerika, Australien sowie auf zahlreichen Inseln ist es heute nahezu weltweit verbreitet. "
    );
    
    animal laus = new animal
    (
    1,
    "Laus",
    "Die Pflanzenläuse (Sternorrhyncha, seltener auch Sternorhyncha) sind eine Unterordnung der Schnabelkerfe (Hemiptera). Von den rund 16.000 bekannten Arten[1] leben etwa 2974 auch in Europa.[2] und 991 in Deutschland.[3][4][5][6] Es handelt sich überwiegend um kleine oder sehr kleine Insekten, die ausnahmslos pflanzensaugend sind. Die Unterordnung ist durch Fossilienfunde bereits aus dem Perm mit neun Familien bekannt."
    );




    animalList.Add(wildschwein);
    animalList.Add(laus);
    
}

//populationsliste






}
