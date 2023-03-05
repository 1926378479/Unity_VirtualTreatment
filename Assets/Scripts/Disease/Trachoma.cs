using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 沙眼
/// </summary>
public class Trachoma : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("眼红");
        AllSymptoms.Add("眼痛");
        AllSymptoms.Add("异物感");
        AllSymptoms.Add("流泪");
        AllSymptoms.Add("畏光");
    }
    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "眼红":
                if (randomIndex == 0)
                {
                    describeText = "照镜子的时候，看见眼睛很红";
                }
                else
                {
                    describeText = "周围人说我眼睛看起来很红";
                }

                break;
            case "眼痛":
                if (randomIndex == 0)
                {
                    describeText = "眼睛有时会感觉到疼痛";
                }
                else
                {
                    describeText = "总觉得眼睛痛";
                }
                break;
            case "异物感":
                if (randomIndex == 0)
                {
                    describeText = "总感觉眼睛里有沙子";
                }
                else
                {
                    describeText = "总会觉得眼睛里有什么东西";
                }
                break;
            case "流泪":
                if (randomIndex == 0)
                {
                    describeText = "有时会控制不住的流泪";
                }
                else
                {
                    describeText = "最近眼睛总是莫名其妙流泪";
                }
                break;
            case "畏光":
                if (randomIndex == 0)
                {
                    describeText = "眼睛在太阳底下会有不适感";
                }
                else
                {
                    describeText = "在明亮的环境下会觉得眼部疼痛";
                }
                break;
        }
    }
}
