using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public bool canStartGame = false;

    private void Start()
    {
        PatientManager.Instance.CreatPatient();
        canStartGame = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canStartGame)
        {
            canStartGame = false;
            UIManager.Instance.dialoguePanel.SetActive(true);
            DialogueManager.Instance.patientFace = Patient.Instance.currentRoleFace;
        }
    }
}
