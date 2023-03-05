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
            ResultPanel.Instance.result.text = "诊断成功！";
            DiseasePanel.Instance.UnLock();
        }
        else
        {
            ResultPanel.Instance.result.text = "诊断失败！";
        }
        GetDescribe(selectionText.text);
    }

    public void GetDescribe(string diseaseName)
    {
        switch (diseaseName)
        {
            case "低血糖":
                ResultPanel.Instance.describe.text = "低血糖症是一组多种病因引起的以静脉血浆葡萄糖（简称血糖）浓度过低，" +
                    "临床上以交感神经兴奋和脑细胞缺氧为主要特点的综合征。" +
                    "低血糖发作时由于交感神经和肾上腺髓质释放肾上腺素、去甲肾上腺素等，" +
                    "临床表现为出汗、饥饿、心慌、颤抖、面色苍白等。";
                break;

            case "贫血症":
                ResultPanel.Instance.describe.text = "贫血是指人体外周血红细胞容量减少，" +
            "低于正常范围下限的一种常见的临床症状。" +
            "由于红细胞容量测定较复杂，临床上常以血红蛋白浓度来代替。" +
            "贫血的病因，血液携氧能力下降的程度，血容量下降的程度，发生贫血" +
            "的速度和血液、循环、呼吸等系统的代偿和耐受能力均会" +
            "影响贫血的临床表现。最早出现的症状有头晕、乏力、困倦；而最常见、最突出的体征是面色苍白。";
                break;

            case "肠胃炎":
                ResultPanel.Instance.describe.text = "胃肠炎通常因微生物感染引起，也可因化学毒物或药品导致。" +
                    "对于健康成人，胃肠炎通常只会引起不适感及生活上的不便，并不会导致严重后果，" +
                    "但是在病重、虚弱、年幼或年老的患者中却可以导致威胁生命的脱水和电解质紊乱。" +
                    "最常见的症状是腹泻，其他症状包括：腹痛、恶心、呕吐、发热、食欲减退" ;
                break;

            case "鼻窦炎":
                ResultPanel.Instance.describe.text = "鼻窦炎一般是指因为病毒、细菌以及过敏反应，甚至真菌感染" +
                    "导致的鼻窦里边的炎症，炎症可以表现为渗出、分泌物增多，甚至在鼻窦里边积液、积脓，形成的鼻窦" +
                    "炎。因为鼻窦本身是窦腔，而窦腔有相对小的开口，鼻窦炎是因为开口黏膜肿胀，出现开口的堵塞，然后" +
                    "鼻窦里面的分泌物形成以后不能得到及时的引流和清除，分泌物就会继发各种病毒和细菌感染，而导致鼻窦炎。";
                break;

            case "感冒":
                ResultPanel.Instance.describe.text = "百姓所说的感冒是指“普通感冒”，又称“伤风”、急性鼻炎或上呼吸道感染。" +
                    "感冒是一种常见的急性上呼吸道病毒性感染性疾病，多由鼻病毒、副流感病毒、呼吸道合胞病毒、埃可病毒、柯萨奇病毒" +
                    "、冠状病毒、腺病毒等引起。临床表现为鼻塞、喷嚏、流涕、发热、咳嗽、头痛等，多呈自限性。大多散发，冬、春季节多发" +
                    "，季节交替时多发。";
                break;

            case "沙眼":
                ResultPanel.Instance.describe.text = "沙眼实际上是沙眼衣原体引起的一种结膜炎,沙眼对眼部的影响非常严重，沙眼衣原体能" +
                    "够引起结膜炎，会引起倒睫、结膜疤痕、角膜炎、血管翳，甚至引起泪道阻塞、泪囊炎，最为严重是眼球萎缩。发现沙眼一定要严格" +
                    "应用抗菌素，用针对沙眼衣原体的眼药膏，甚至用抗菌素都能够治好沙眼。";
                break;

            default:
                break;
        }
    }
}
