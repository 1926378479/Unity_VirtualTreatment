using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    public bool isCorrectAnswer;
    public Text selectionText;

    public void OnClick()
    {
        UIManager.Instance.curePanel.SetActive(false);
        if (isCorrectAnswer)
        {
            UIManager.Instance.successPanel.SetActive(true);
            DiseasePanel.Instance.UnLock();
        }
        else
        {
            UIManager.Instance.failPanel.SetActive(true);
        }
    }
}
