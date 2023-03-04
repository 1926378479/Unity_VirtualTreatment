using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurePanel : MonoBehaviour
{
    public List<Selection> selections;
    

    private void Start()
    {
        InitSelections();
    }
    public void InitSelections()
    {
        int index = Random.Range(0, 3);
        selections[index].isCorrectAnswer = true;
        selections[index].selectionText.text = Patient.Instance.currentDisease;
        selections.RemoveAt(index);
        selections[0].selectionText.text = "0";
        selections[1].selectionText.text = "0";
    }
}
