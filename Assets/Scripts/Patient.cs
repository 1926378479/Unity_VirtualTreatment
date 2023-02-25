using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : MonoBehaviour
{
    public string currentDisease;

    public Sprite currentRoleFace;

    string sayText;

    private void Start()
    {
        currentDisease = DiseaseManager.InitDisease();
        AddDisease(currentDisease);
        DialogueManager.Instance.patientFace = currentRoleFace;
        
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
    //public void AddSayText()
    //{
    //    Disease curDisease = GetComponent<Disease>();
    //    //for (int i = 0; i < curDisease.; i++)
    //    //{

    //    //}
    //    var a = curDisease.AllSymptoms[0];
    //}
}
