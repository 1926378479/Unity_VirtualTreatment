using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurePanel : MonoBehaviour
{
    public List<Selection> selections;

    public List<string> tempDiseaseGroup = new List<string>();
    

    private void Start()
    {
        foreach (var disease in DiseaseManager.DiseaseGroup)
        {
            tempDiseaseGroup.Add(disease);
        }
        InitSelections();
    }
    public void InitSelections()
    {
        int index = Random.Range(0, 3);
        selections[index].isCorrectAnswer = true;
        selections[index].selectionText.text = Patient.Instance.currentDisease;
        selections.RemoveAt(index);

        tempDiseaseGroup.Remove(Patient.Instance.currentDisease);

        int random0 = Random.Range(0, tempDiseaseGroup.Count);
        selections[0].selectionText.text = tempDiseaseGroup[random0];
        tempDiseaseGroup.RemoveAt(random0);

        int random1 = Random.Range(0, tempDiseaseGroup.Count);
        selections[1].selectionText.text = tempDiseaseGroup[random1];
        tempDiseaseGroup.RemoveAt(random1);
    }
}
