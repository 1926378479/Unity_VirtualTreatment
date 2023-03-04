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
        AllSymptoms.Add("����");
        AllSymptoms.Add("����״̬������");
        AllSymptoms.Add("��֫����");
    }


    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "ͷ��":
                if (randomIndex == 0)
                {
                    describeText = "����ʱ��о�ͷ����";
                }
                else
                {
                    describeText = "����ʱ�о���ð���ǣ�������ת";
                }
                
                break;
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "�Ҹо��������������˵�����";
                }
                else
                {
                    describeText = "�Ҹо���������������";
                }
                break;
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "��ʱ�����������ʧȥ��ʶ";
                }
                else
                {
                    describeText = "��ʱ�����ǰ����";
                }
                break;
            case "����״̬������":
                if (randomIndex == 0)
                {
                    describeText = "��ʱ�ھ�����ʱ��Ҳ��������";
                }
                else
                {
                    describeText = "û�˶�ȴ��������";
                }
                break;
            case "��֫����":
                if (randomIndex == 0)
                {
                    describeText = "������ֽ�ʹ������";
                }
                else
                {
                    describeText = "�о�����ʹ��������";
                }
                break;
        }
    }
}
