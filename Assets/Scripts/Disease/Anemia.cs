using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ƶѪ
public class Anemia : Disease
{
    private void Start()
    {
        InitAllSymptoms();
        InitSymptoms();
    }

    public void InitAllSymptoms()
    {
        AllSymptoms.Add("ͷ��");
        AllSymptoms.Add("����");
        AllSymptoms.Add("ʧ��");
        AllSymptoms.Add("����");
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
