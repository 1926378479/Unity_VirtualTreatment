using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DiseaseManager : MonoBehaviour
{
    
    public static string[] DiseaseGroup = new string[] { "ƶѪ֢" , "��Ѫ��" };

    public static string InitDisease()
    {
        return DiseaseGroup[Random.Range(0, DiseaseGroup.Length)];
    }
}
