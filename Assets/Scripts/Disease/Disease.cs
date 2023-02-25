using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disease : MonoBehaviour
{
    public string describeText;
    // 所有症状
    public List<string> AllSymptoms = new List<string>();

    // 表现症状
    public List<string> Symptoms = new List<string>();

    public virtual void Start()
    {
        InitAllSymptoms();
        InitSymptoms();
    }

    //public static List<string> diseaseDescr = new List<string>();

    public virtual void InitAllSymptoms()
    {

    }
    public virtual void InitSymptoms()
    {
        int index;
        for (int i = 0; i < 2; i++)
        {
            index = Random.Range(0, AllSymptoms.Count);
            InitSayText(AllSymptoms[index]);
            AddSayText(describeText);
            Symptoms.Add(AllSymptoms[index]);
            AllSymptoms.RemoveAt(index);
        }
    }

    public virtual void InitSayText(string symptoms)
    {

    }
    public virtual void AddSayText(string text)
    {
        DialogueManager.Instance.textList.Add("Patient");
        DialogueManager.Instance.textList.Add(text);
    }
}
