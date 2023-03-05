using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��ð
/// </summary>
public class Cold : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("����");
        AllSymptoms.Add("����");
        AllSymptoms.Add("������");
        AllSymptoms.Add("����");
        AllSymptoms.Add("����");
    }
    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "������Ժ��������о��ζ�Ҫ�ȳ�����";
                }
                else
                {
                    describeText = "������Ǹɿȣ�ɤ�Ӻ�ʹ";
                }

                break;
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "�⼸�����������飬���������";
                }
                else
                {
                    describeText = "���Ӳ��������������";
                }
                break;
            case "������":
                if (randomIndex == 0)
                {
                    describeText = "����������������";
                }
                else
                {
                    describeText = "��ʱ���ֹ��ס������ü�������";
                }
                break;
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "���Ӳ�ͨ��";
                }
                else
                {
                    describeText = "�������Ǹо�����ס��";
                }
                break;
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "���췢���ˣ�����38��";
                }
                else
                {
                    describeText = "���ͷ�о����գ��������£�38��";
                }
                break;
        }
    }
}
