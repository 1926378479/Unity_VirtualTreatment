using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DiseaseManager : MonoBehaviour
{

    public static List<string> DiseaseGroup = new List<string>() { "ƶѪ֢"/*, "��Ѫ��", "��θ��", "�����", "��ð", "ɳ��"*/ };

    public static string InitDisease()
    {
        return DiseaseGroup[Random.Range(0, DiseaseGroup.Count)];
    }
}
