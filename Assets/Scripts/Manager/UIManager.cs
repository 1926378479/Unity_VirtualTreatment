using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : Singleton<UIManager>
{
    public GameObject dialoguePanel;
    public GameObject curePanel;

    public GameObject resultPanel;
    public GameObject diseasePanel;

    private void Start()
    {
        HideAllPanel();
    }

    public void ShowPanel(GameObject panel)
    {
        panel.SetActive(true);
    }
    public void HidePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void HideAllPanel()
    {
        HidePanel(dialoguePanel);
        HidePanel(curePanel);
        HidePanel(resultPanel);
        HidePanel(diseasePanel);
    }
    public void RestartGame()
    {
        for (int i = 0; i < DiseasePanel.Instance.diseasePhotos.Count; i++)
        {
            if (DiseasePanel.Instance.diseasePhotos[i].lockImage.activeSelf)
            {
                PlayerPrefs.SetInt("Photo" + i.ToString(), 0);
            }
            else
            {
                PlayerPrefs.SetInt("Photo" + i.ToString(), 1);
            }
            
        }
        //HideAllPanel();
        //Destroy(PatientManager.Instance.currentPatient);
        //PatientManager.Instance.CreatPatient();
        //GameManager.Instance.canStartGame = true;
        SceneManager.LoadScene(1);
    }
}
