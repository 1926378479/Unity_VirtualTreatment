using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PatientManager : Singleton<PatientManager>
{
    public GameObject[] PatientGroup;
    public Transform startPos;
    public GameObject currentPatient;

    public void CreatPatient()
    {
        GameObject Patient = PatientGroup[Random.Range(0, PatientGroup.Length)];
        currentPatient = Instantiate(Patient, startPos.position,startPos.rotation);
    }
}
