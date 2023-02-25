using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��Ѫ��
public class Hypoglycemia : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("�Ļ�");
        AllSymptoms.Add("��ɫ�԰�");
        AllSymptoms.Add("����");
        AllSymptoms.Add("����������");
    }
    public override void InitSayText(string symptoms)
    {
        switch (symptoms)
        {
            case "�Ļ�":
                describeText = "��ͷ���ΰ���Ҫ�����ˣ�����������";
                break;
            case "��ɫ�԰�":
                describeText = "�е����������";
                break;
            case "����":
                describeText = "ʧ���ˣ�����";
                break;
            case "����������":
                describeText = "���϶��Σ�������";
                break;
        }
    }
    
}
