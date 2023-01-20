using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// µÍÑªÌÇ
public class Hypoglycemia : Disease
{
    private void Start()
    {
        InitAllSymptoms();
        InitSymptoms();
    }

    public void InitAllSymptoms()
    {
        AllSymptoms.Add("ÐÄ»Å");
        AllSymptoms.Add("Á³É«²Ô°×");
        AllSymptoms.Add("³öº¹");
        AllSymptoms.Add("¸¹²¿¼¢¶ö¸Ð");
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
