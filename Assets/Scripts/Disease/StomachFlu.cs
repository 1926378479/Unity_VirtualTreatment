using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��θ��
/// </summary>
public class StomachFlu : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("��к");
        AllSymptoms.Add("����");
        AllSymptoms.Add("Ż��");
        AllSymptoms.Add("��ʹ");
    }
    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "��к":
                if (randomIndex == 0)
                {
                    describeText = "�������������";
                }
                else
                {
                    describeText = "�����˯����ʱ����˵㶫������Ź���һ�ᣬ�͸о���������";
                }

                break;
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "��ʱ�᷸����";
                }
                else
                {
                    describeText = "���������о�����";
                }
                break;
            case "Ż��":
                if (randomIndex == 0)
                {
                    describeText = "�������ϳ��˸�����֮��о����岻̫�Ծ�����������";
                }
                else
                {
                    describeText = "�����û��ô�Զ��������˾���";
                }
                break;
            case "��ʹ":
                if (randomIndex == 0)
                {
                    describeText = "������Ƕ���ʹ";
                }
                else
                {
                    describeText = "������극������ƿ�����֣�����ʹ��һ����";
                }
                break;
        }
    }
}
