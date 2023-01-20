using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��Ѫ��
public class Hypoglycemia : Disease
{
    private void Start()
    {
        InitAllSymptoms();
        InitSymptoms();
    }

    public void InitAllSymptoms()
    {
        AllSymptoms.Add("�Ļ�");
        AllSymptoms.Add("��ɫ�԰�");
        AllSymptoms.Add("����");
        AllSymptoms.Add("����������");
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
