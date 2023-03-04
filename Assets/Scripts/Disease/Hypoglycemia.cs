using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��Ѫ��
public class Hypoglycemia : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("����");
        AllSymptoms.Add("��ɫ�԰�");
        AllSymptoms.Add("��ǰ����");
        AllSymptoms.Add("����");
    }
    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "�˶��󣬲���ȴ������";
                }
                else
                {
                    describeText = "�˶��󣬻���ܶ���亹";
                }
                    
                break;
            case "��ɫ�԰�":
                if (randomIndex == 0)
                {
                    describeText = "֮ǰ������ȥ�˶�����������˵����ɫ�е��";
                }
                else
                {
                    describeText = "�������ܲ������󣬱��ϵ���˵����ɫ�԰�";
                }
                break;
            case "��ǰ����":
                if (randomIndex == 0)
                {
                    describeText = "û���緹������ȥ�Է���ʱ����ǰ�е㷢��";
                }
                else
                {
                    describeText = "û���з���ȥ������ʱ����ǰһ�ڣ���㵹������";
                }
                break;
            case "����":
                if (randomIndex == 0)
                {
                    describeText = "����ʱ�������֫����";
                }
                else
                {
                    describeText = "���������ʹ��������";
                }
                break;
        }
    }
    
}
