using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disease : MonoBehaviour
{
    public string describeText;

    public bool isInit = false;

    public int createSymNum = 4;

    public static string diseaseDescribe;
    // 所有症状
    public List<string> AllSymptoms = new List<string>();

    // 表现症状
    public List<string> Symptoms = new List<string>();

    public virtual void Update()
    {
        if (!GameManager.Instance.canStartGame && !isInit)
        {
            isInit = true;
            InitAllSymptoms();
            InitSymptoms();
            InitDescribe();
        }
    }

    public virtual void InitAllSymptoms()
    {

    }
    public virtual void InitSymptoms()
    {
        int index;
        for (int i = 0; i < createSymNum; i++)
        {
            index = Random.Range(0, AllSymptoms.Count);
            InitSayText(AllSymptoms[index],Random.Range(0,2));
            AddSayText(describeText);
            Symptoms.Add(AllSymptoms[index]);
            AllSymptoms.RemoveAt(index);
        }
    }

    public virtual void InitSayText(string symptoms,int randomIndex)
    {

    }
    public virtual void AddSayText(string text)
    {
        DialogueManager.Instance.textList.Add("Patient");
        DialogueManager.Instance.textList.Add(text);
    }
    public virtual void InitDescribe()
    {

    }
}
