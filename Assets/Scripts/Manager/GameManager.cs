using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    public bool canStartGame = false;

    private void Start()
    {
        PatientManager.Instance.CreatPatient();
        InitData();
        canStartGame = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && canStartGame)
        {
            canStartGame = false;
            UIManager.Instance.dialoguePanel.SetActive(true);
            DialogueManager.Instance.patientFace = Patient.Instance.currentRoleFace;
        }
    }
    public void InitData()
    {
        for (int i = 0; i < DiseasePanel.Instance.diseasePhotos.Count; i++)
        {
            if (PlayerPrefs.GetInt("Photo" + i.ToString())==1)
            {
                DiseasePanel.Instance.diseasePhotos[i].lockImage.SetActive(false);
                DiseasePanel.Instance.diseasePhotos[i].GetComponent<Button>().interactable = true;
            }

        }
    }
}
