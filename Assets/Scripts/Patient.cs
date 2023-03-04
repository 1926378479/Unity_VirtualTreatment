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
            case "ƶѪ֢":
                gameObject.AddComponent<Anemia>();
                break;
            case "��Ѫ��":
                gameObject.AddComponent<Hypoglycemia>();
                break;
        }
    }
}
