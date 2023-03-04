using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiseasePanel : Singleton<DiseasePanel>
{
    public List<DiseasePhoto> diseasePhotos;
    public void ShowDiseasePanel()
    {
        gameObject.SetActive(true);
    }
    public void HideDiseasePanel()
    {
        gameObject.SetActive(false);
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

}
