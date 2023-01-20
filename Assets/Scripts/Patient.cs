using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : MonoBehaviour
{
    public string CurrentDisease;
    private void Start()
    {
        CurrentDisease = DiseaseManager.InitDisease();
        AddDisease(CurrentDisease);
    }
    public void AddDisease(string disease)
    {
        switch (disease)
        {
            case "Anemia":
                gameObject.AddComponent<Anemia>();
                break;
            case "Hypoglycemia":
                gameObject.AddComponent<Hypoglycemia>();
                break;
        }
    }
}
