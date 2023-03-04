using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 低血糖
public class Hypoglycemia : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("出汗");
        AllSymptoms.Add("脸色苍白");
        AllSymptoms.Add("眼前发黑");
        AllSymptoms.Add("乏力");
    }
    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "出汗":
                if (randomIndex == 0)
                {
                    describeText = "运动后，不热却疯狂出汗";
                }
                else
                {
                    describeText = "运动后，会出很多的冷汗";
                }
                    
                break;
            case "脸色苍白":
                if (randomIndex == 0)
                {
                    describeText = "之前和朋友去运动，结束后，他说我脸色有点白";
                }
                else
                {
                    describeText = "体育课跑步结束后，边上的人说我脸色苍白";
                }
                break;
            case "眼前发黑":
                if (randomIndex == 0)
                {
                    describeText = "没吃早饭，中午去吃饭的时候眼前有点发黑";
                }
                else
                {
                    describeText = "没吃中饭，去吃晚饭的时候眼前一黑，差点倒地上了";
                }
                break;
            case "乏力":
                if (randomIndex == 0)
                {
                    describeText = "发作时会觉得四肢乏力";
                }
                else
                {
                    describeText = "会觉得身体使不上力气";
                }
                break;
        }
    }
    
}
