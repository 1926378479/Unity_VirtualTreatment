using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Æ¶Ñª
public class Anemia : Disease
{
    private void Start()
    {
        InitAllSymptoms();
        InitSymptoms();
    }

    public void InitAllSymptoms()
    {
        AllSymptoms.Add("Í·ÔÎ");
        AllSymptoms.Add("¶úÃù");
        AllSymptoms.Add("Ê§Ãß");
        AllSymptoms.Add("¶àÃÎ");
    }

    public void InitSymptoms()
    {
        int index;
        for (int i = 0; i < 2; i++)
        {
            index = Random.Range(0, AllSymptoms.Count);
            Symptoms.Add(AllSymptoms[index]);
            AllSymptoms.RemoveAt(index);
        }
    }
}
