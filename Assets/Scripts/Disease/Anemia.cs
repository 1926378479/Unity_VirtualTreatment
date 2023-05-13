using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ƶѪ
/// </summary>
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

        //switch (symptoms)
        //{
        //    case "ͷ��":
        //        if (randomIndex == 0)
        //        {
        //            describeText = "����ʱ��о�ͷ����";
        //        }
        //        else
        //        {
        //            describeText = "����ʱ�о���ð���ǣ�������ת";
        //        }
                
        //        break;
        //    case "����":
        //        if (randomIndex == 0)
        //        {
        //            describeText = "�Ҹо��������������˵�����";
        //        }
        //        else
        //        {
        //            describeText = "�Ҹо���������������";
        //        }
        //        break;
        //    case "����":
        //        if (randomIndex == 0)
        //        {
        //            describeText = "��ʱ�����������ʧȥ��ʶ";
        //        }
        //        else
        //        {
        //            describeText = "��ʱ�����ǰ����";
        //        }
        //        break;
        //    case "����״̬������":
        //        if (randomIndex == 0)
        //        {
        //            describeText = "��ʱ�ھ�����ʱ��Ҳ��������";
        //        }
        //        else
        //        {
        //            describeText = "û�˶�ȴ��������";
        //        }
        //        break;
        //    case "��֫����":
        //        if (randomIndex == 0)
        //        {
        //            describeText = "������ֽ�ʹ������";
        //        }
        //        else
        //        {
        //            describeText = "�о�����ʹ��������";
        //        }
        //        break;
        //}
    }
    public override void InitDescribe()
    {
        diseaseDescribe = "ƶѪ��ָ��������Ѫ��ϸ���������٣�" +
            "����������Χ���޵�һ�ֳ������ٴ�֢״��" +
            "���ں�ϸ�������ⶨ�ϸ��ӣ��ٴ��ϳ���Ѫ�쵰��Ũ�������档" +
            "ƶѪ�Ĳ���ѪҺЯ�������½��ĳ̶ȣ�Ѫ�����½��ĳ̶ȣ�����ƶѪ" +
            "���ٶȺ�ѪҺ��ѭ����������ϵͳ�Ĵ�����������������" +
            "Ӱ��ƶѪ���ٴ����֡�������ֵ�֢״��ͷ�Ρ����������룻���������ͻ������������ɫ�԰ס�";
    }
}
