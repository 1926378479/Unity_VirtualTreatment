using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ɳ��
/// </summary>
public class Trachoma : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("�ۺ�");
        AllSymptoms.Add("��ʹ");
        AllSymptoms.Add("�����");
        AllSymptoms.Add("����");
        AllSymptoms.Add("η��");
    }
    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "�ۺ�":
                if (randomIndex == 0)
                {
                    describeText = "�վ��ӵ�ʱ�򣬿����۾��ܺ�";
                }
                else
                {
                    describeText = "��Χ��˵���۾��������ܺ�";
                }

                break;
            case "��ʹ":
                if (randomIndex == 0)
                {
                    describeText = "�۾���ʱ��о�����ʹ";
                }
                else
                {
                    describeText = "�ܾ����۾�ʹ";
                }
                break;
            case "�����":
                if (randomIndex == 0)
                {
                    describeText = "�ܸо��۾�����ɳ��";
                }
                else
                {
                    describeText = "�ܻ�����۾�����ʲô����";
                }
                break;
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "��ʱ����Ʋ�ס������";
                }
                else
                {
                    describeText = "����۾�����Ī����������";
                }
                break;
            case "η��":
                if (randomIndex == 0)
                {
                    describeText = "�۾���̫�����»��в��ʸ�";
                }
                else
                {
                    describeText = "�������Ļ����»�����۲���ʹ";
                }
                break;
        }
    }
}
