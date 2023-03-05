using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 感冒
/// </summary>
public class Cold : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("咳嗽");
        AllSymptoms.Add("流涕");
        AllSymptoms.Add("打喷嚏");
        AllSymptoms.Add("鼻塞");
        AllSymptoms.Add("发热");
    }
    public override void InitSayText(string symptoms, int randomIndex)
    {
        switch (symptoms)
        {
            case "咳嗽":
                if (randomIndex == 0)
                {
                    describeText = "最近咳嗽很厉害，感觉肺都要咳出来了";
                }
                else
                {
                    describeText = "最近总是干咳，嗓子很痛";
                }

                break;
            case "流涕":
                if (randomIndex == 0)
                {
                    describeText = "这几天总是流鼻涕，喉咙不舒服";
                }
                else
                {
                    describeText = "鼻子不舒服，总流鼻涕";
                }
                break;
            case "打喷嚏":
                if (randomIndex == 0)
                {
                    describeText = "早上起来疯狂打喷嚏";
                }
                else
                {
                    describeText = "又时候会止不住的连打好几个喷嚏";
                }
                break;
            case "鼻塞":
                if (randomIndex == 0)
                {
                    describeText = "鼻子不通气";
                }
                else
                {
                    describeText = "鼻子总是感觉被塞住了";
                }
                break;
            case "发热":
                if (randomIndex == 0)
                {
                    describeText = "昨天发烧了，烧了38度";
                }
                else
                {
                    describeText = "最近头感觉很烧，量了体温，38度";
                }
                break;
        }
    }
}
