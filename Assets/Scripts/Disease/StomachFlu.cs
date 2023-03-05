using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 肠胃炎
/// </summary>
public class StomachFlu : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("腹泻");
        AllSymptoms.Add("恶心");
        AllSymptoms.Add("呕吐");
        AllSymptoms.Add("腹痛");
    }
    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "腹泻":
                if (randomIndex == 0)
                {
                    describeText = "最近总是拉肚子";
                }
                else
                {
                    describeText = "昨天快睡觉的时候吃了点东西，大概过了一会，就感觉想拉肚子";
                }

                break;
            case "恶心":
                if (randomIndex == 0)
                {
                    describeText = "有时会犯恶心";
                }
                else
                {
                    describeText = "最近经常会感觉想吐";
                }
                break;
            case "呕吐":
                if (randomIndex == 0)
                {
                    describeText = "昨天晚上吃了根棒冰之后感觉身体不太对劲，马上吐了";
                }
                else
                {
                    describeText = "最近都没怎么吃东西，吃了就吐";
                }
                break;
            case "腹痛":
                if (randomIndex == 0)
                {
                    describeText = "最近总是肚子痛";
                }
                else
                {
                    describeText = "昨天吃完饭，喝了瓶冰可乐，肚子痛了一晚上";
                }
                break;
        }
    }
}
