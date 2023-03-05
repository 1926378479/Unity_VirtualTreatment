using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �����
/// </summary>
public class Nasosinusitis : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("����");
        AllSymptoms.Add("ŧ��");
        AllSymptoms.Add("ζ������");
        AllSymptoms.Add("�������");
    }
    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "���ӻ���һ�쵽�������ŵģ�������";
                }
                else
                {
                    describeText = "����ͨ������������ֻ���������";
                }

                break;
            case "ŧ��":
                if (randomIndex == 0)
                {
                    describeText = "�������������ܶ���飬ֹ��ס";
                }
                else
                {
                    describeText = "��ʱ���ҹ���������ӻ����ǳ���ı���";
                }
                break;
            case "ζ������":
                if (randomIndex == 0)
                {
                    describeText = "������Ӳ��������ʲô���о�ζ���ܵ�";
                }
                else
                {
                    describeText = "����Է��ܸо��˶�ûʲôζ��";
                }
                break;
            case "�������":
                if (randomIndex == 0)
                {
                    describeText = "��������Ų���ʲôζ�����о������̫����";
                }
                else
                {
                    describeText = "�����죬�����������Ų���ζ��";
                }
                break;
        }
    }
}
