using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : Singleton<Patient>
{
    public string currentDisease;

    public Sprite currentRoleFace;

    private void Start()
    {
        currentDisease = DiseaseManager.InitDisease();
        AddDisease(currentDisease);
    }
    public void AddDisease(string disease)
    {
        switch (disease)
        {
            case "贫血症":
                gameObject.AddComponent<Anemia>();
                GptTurboScript.Instance.Prompt = "我是一名该死的老师，喜欢辱骂学生";
                GptTurboScript.Instance.AddSystem();
                break;
            case "低血糖":
                gameObject.AddComponent<Hypoglycemia>();
                break;
            case "肠胃炎":
                gameObject.AddComponent<StomachFlu>();
                break;
            case "鼻窦炎":
                gameObject.AddComponent<Nasosinusitis>();
                break;
            case "感冒":
                gameObject.AddComponent<Cold>();
                break;
            case "沙眼":
                gameObject.AddComponent<Trachoma>();
                break;


        }
    }
}
