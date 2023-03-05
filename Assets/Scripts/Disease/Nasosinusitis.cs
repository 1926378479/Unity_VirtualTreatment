using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 鼻窦炎
/// </summary>
public class Nasosinusitis : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("鼻塞");
        AllSymptoms.Add("脓涕");
        AllSymptoms.Add("味觉减退");
        AllSymptoms.Add("嗅觉减退");
    }
    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "鼻塞":
                if (randomIndex == 0)
                {
                    describeText = "鼻子基本一天到晚都是塞着的，很难受";
                }
                else
                {
                    describeText = "鼻子通不了气，基本只能用嘴呼吸";
                }

                break;
            case "脓涕":
                if (randomIndex == 0)
                {
                    describeText = "早上起来会流很多鼻涕，止不住";
                }
                else
                {
                    describeText = "有时候半夜醒来，鼻子会流非常多的鼻涕";
                }
                break;
            case "味觉减退":
                if (randomIndex == 0)
                {
                    describeText = "昨天鼻子不舒服，吃什么都感觉味道很淡";
                }
                else
                {
                    describeText = "最近吃饭总感觉菜都没什么味道";
                }
                break;
            case "嗅觉减退":
                if (randomIndex == 0)
                {
                    describeText = "最近基本闻不到什么味道，感觉嗅觉不太行了";
                }
                else
                {
                    describeText = "近几天，鼻子总塞，闻不到味道";
                }
                break;
        }
    }
}
