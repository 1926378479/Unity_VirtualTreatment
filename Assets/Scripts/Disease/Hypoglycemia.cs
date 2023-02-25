using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 低血糖
public class Hypoglycemia : Disease
{
    public override void InitAllSymptoms()
    {
        AllSymptoms.Add("心慌");
        AllSymptoms.Add("脸色苍白");
        AllSymptoms.Add("出汗");
        AllSymptoms.Add("腹部饥饿感");
    }
    public override void InitSayText(string symptoms)
    {
        switch (symptoms)
        {
            case "心慌":
                describeText = "我头好晕啊，要死掉了！！！！！！";
                break;
            case "脸色苍白":
                describeText = "有点耳鸣！！！";
                break;
            case "出汗":
                describeText = "失眠了！！！";
                break;
            case "腹部饥饿感":
                describeText = "晚上多梦！！！！";
                break;
        }
    }
    
}
