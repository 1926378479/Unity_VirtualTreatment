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
        AllSymptoms.Add("失眠");
        AllSymptoms.Add("多梦");
    }


    public override void InitSayText(string symptoms)
    {
        
        switch (symptoms)
        {
            case "头晕":
                describeText = "我头好晕啊，要死掉了！！！！！！";
                break;
            case "耳鸣":
                describeText = "有点耳鸣！！！";
                break;
            case "失眠":
                describeText = "失眠了！！！";
                break;
            case "多梦":
                describeText = "晚上多梦！！！！";
                break;
        }
    }
}
