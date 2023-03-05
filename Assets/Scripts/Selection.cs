using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    public bool isCorrectAnswer;
    public Text selectionText;
    public string currentSelectionName;

    public void OnClick()
    {
        UIManager.Instance.curePanel.SetActive(false);
        UIManager.Instance.resultPanel.SetActive(true);
        if (isCorrectAnswer)
        {
            ResultPanel.Instance.result.text = "��ϳɹ���";
            DiseasePanel.Instance.UnLock();
        }
        else
        {
            ResultPanel.Instance.result.text = "���ʧ�ܣ�";
        }
        GetDescribe(selectionText.text);
    }

    public void GetDescribe(string diseaseName)
    {
        switch (diseaseName)
        {
            case "��Ѫ��":
                ResultPanel.Instance.describe.text = "��Ѫ��֢��һ����ֲ���������Ծ���Ѫ�������ǣ����Ѫ�ǣ�Ũ�ȹ��ͣ�" +
                    "�ٴ����Խ������˷ܺ���ϸ��ȱ��Ϊ��Ҫ�ص���ۺ�����" +
                    "��Ѫ�Ƿ���ʱ���ڽ����񾭺������������ͷ��������ء�ȥ���������صȣ�" +
                    "�ٴ�����Ϊ�������������Ļš���������ɫ�԰׵ȡ�";
                break;

            case "ƶѪ֢":
                ResultPanel.Instance.describe.text = "ƶѪ��ָ��������Ѫ��ϸ���������٣�" +
            "����������Χ���޵�һ�ֳ������ٴ�֢״��" +
            "���ں�ϸ�������ⶨ�ϸ��ӣ��ٴ��ϳ���Ѫ�쵰��Ũ�������档" +
            "ƶѪ�Ĳ���ѪҺЯ�������½��ĳ̶ȣ�Ѫ�����½��ĳ̶ȣ�����ƶѪ" +
            "���ٶȺ�ѪҺ��ѭ����������ϵͳ�Ĵ�����������������" +
            "Ӱ��ƶѪ���ٴ����֡�������ֵ�֢״��ͷ�Ρ����������룻���������ͻ������������ɫ�԰ס�";
                break;

            case "��θ��":
                ResultPanel.Instance.describe.text = "θ����ͨ����΢�����Ⱦ����Ҳ����ѧ�����ҩƷ���¡�" +
                    "���ڽ������ˣ�θ����ͨ��ֻ�������ʸм������ϵĲ��㣬�����ᵼ�����غ����" +
                    "�����ڲ��ء����������׻����ϵĻ�����ȴ���Ե�����в��������ˮ�͵�������ҡ�" +
                    "�����֢״�Ǹ�к������֢״��������ʹ�����ġ�Ż�¡����ȡ�ʳ������" ;
                break;

            case "�����":
                ResultPanel.Instance.describe.text = "�����һ����ָ��Ϊ������ϸ���Լ�������Ӧ�����������Ⱦ" +
                    "���µı����ߵ���֢����֢���Ա���Ϊ���������������࣬�����ڱ����߻�Һ����ŧ���γɵı��" +
                    "�ס���Ϊ��񼱾�����ǻ�����ǻ�����С�Ŀ��ڣ����������Ϊ�����Ĥ���ͣ����ֿ��ڵĶ�����Ȼ��" +
                    "�������ķ������γ��Ժ��ܵõ���ʱ�������������������ͻ�̷����ֲ�����ϸ����Ⱦ�������±���ס�";
                break;

            case "��ð":
                ResultPanel.Instance.describe.text = "������˵�ĸ�ð��ָ����ͨ��ð�����ֳơ��˷硱�����Ա��׻��Ϻ�������Ⱦ��" +
                    "��ð��һ�ֳ����ļ����Ϻ����������Ը�Ⱦ�Լ��������ɱǲ����������в������������ϰ����������ɲ����������没��" +
                    "����״�������ٲ����������ٴ�����Ϊ���������硢���顢���ȡ����ԡ�ͷʹ�ȣ���������ԡ����ɢ�������������ڶ෢" +
                    "�����ڽ���ʱ�෢��";
                break;

            case "ɳ��":
                ResultPanel.Instance.describe.text = "ɳ��ʵ������ɳ����ԭ�������һ�ֽ�Ĥ��,ɳ�۶��۲���Ӱ��ǳ����أ�ɳ����ԭ����" +
                    "�������Ĥ�ף������𵹽ޡ���Ĥ�̺ۡ���Ĥ�ס�Ѫ���裬����������������������ף���Ϊ����������ή��������ɳ��һ��Ҫ�ϸ�" +
                    "Ӧ�ÿ����أ������ɳ����ԭ�����ҩ�࣬�����ÿ����ض��ܹ��κ�ɳ�ۡ�";
                break;

            default:
                break;
        }
    }
}
