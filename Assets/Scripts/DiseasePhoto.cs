using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiseasePhoto : MonoBehaviour
{
    public string diseaseName;
    public GameObject lockImage;
    public void ClickPhoto()
    {
        AudioManager.Instance.PlayBtnClick();
        SetPhotoContent();
    }
    public void SetPhotoContent()
    {
        DiseasePanel.Instance.rightDiseaseName.text = diseaseName;
        DiseasePanel.Instance.rightDiseaseContent.text = Selection.GetDescribe(diseaseName);
    }
}
