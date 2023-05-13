using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiseasePanel : Singleton<DiseasePanel>
{
    public List<DiseasePhoto> diseasePhotos;
    public Text rightDiseaseName;
    public Text rightDiseaseContent;
    public void ShowDiseasePanel()
    {
        gameObject.SetActive(true);
        UIManager.Instance.backMainBtn.SetActive(false);
        AudioManager.Instance.PlayBookSound();
        if (GetDefaultContent() == -1)
        {
            rightDiseaseName.gameObject.SetActive(false);
            rightDiseaseContent.gameObject.SetActive(false);
        }
        else
        {
            rightDiseaseName.gameObject.SetActive(true);
            rightDiseaseContent.gameObject.SetActive(true);
            diseasePhotos[GetDefaultContent()].SetPhotoContent();
        }
    }
    public void HideDiseasePanel()
    {
        gameObject.SetActive(false);
        UIManager.Instance.backMainBtn.SetActive(true);
        AudioManager.Instance.PlayBtnClick();
    }

    public void UnLock()
    {
        for (int i = 0; i < diseasePhotos.Count; i++)
        {
            if (diseasePhotos[i].diseaseName == Patient.Instance.currentDisease)
            {
                diseasePhotos[i].lockImage.SetActive(false);
                diseasePhotos[i].GetComponent<Button>().interactable = true;
            }

        }
    }
    public int GetDefaultContent()
    {
        for (int i = 0; i < diseasePhotos.Count; i++)
        {
            if (!diseasePhotos[i].lockImage.activeSelf)
            {
                return i;
            }
        }
        return -1;
    }

}
