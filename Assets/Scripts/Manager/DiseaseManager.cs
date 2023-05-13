using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DiseaseManager : MonoBehaviour
{

    public static List<string> DiseaseGroup = new List<string>() { "Æ¶ÑªÖ¢"/*, "µÍÑªÌÇ", "³¦Î¸Ñ×", "±Çñ¼Ñ×", "¸ÐÃ°", "É³ÑÛ"*/ };

    public static string InitDisease()
    {
        return DiseaseGroup[Random.Range(0, DiseaseGroup.Count)];
    }
}
