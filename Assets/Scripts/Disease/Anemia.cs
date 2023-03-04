using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 贫血
public class Anemia : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("头晕");
        AllSymptoms.Add("耳鸣");
        AllSymptoms.Add("晕厥");
        AllSymptoms.Add("安静状态下气短");
        AllSymptoms.Add("四肢无力");
    }


    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "头晕":
                if (randomIndex == 0)
                {
                    describeText = "我有时会感觉头很晕";
                }
                else
                {
                    describeText = "我有时感觉眼冒金星，天旋地转";
                }
                
                break;
            case "耳鸣":
                if (randomIndex == 0)
                {
                    describeText = "我感觉耳朵里有嗡嗡嗡的声音";
                }
                else
                {
                    describeText = "我感觉耳朵里有咔哒声";
                }
                break;
            case "晕厥":
                if (randomIndex == 0)
                {
                    describeText = "有时候甚至会短暂失去意识";
                }
                else
                {
                    describeText = "有时候会眼前发黑";
                }
                break;
            case "安静状态下气短":
                if (randomIndex == 0)
                {
                    describeText = "有时在静坐的时候也觉得气短";
                }
                else
                {
                    describeText = "没运动却呼吸急促";
                }
                break;
            case "四肢无力":
                if (randomIndex == 0)
                {
                    describeText = "会觉得手脚使不上力";
                }
                else
                {
                    describeText = "感觉身体使不上力气";
                }
                break;
        }
    }
}
