using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ƶѪ
public class Anemia : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("ͷ��");
        AllSymptoms.Add("����");
        AllSymptoms.Add("ʧ��");
        AllSymptoms.Add("����");
    }


    public override void InitSayText(string symptoms)
    {
        
        switch (symptoms)
        {
            case "ͷ��":
                describeText = "��ͷ���ΰ���Ҫ�����ˣ�����������";
                break;
            case "����":
                describeText = "�е����������";
                break;
            case "ʧ��":
                describeText = "ʧ���ˣ�����";
                break;
            case "����":
                describeText = "���϶��Σ�������";
                break;
        }
    }
}
