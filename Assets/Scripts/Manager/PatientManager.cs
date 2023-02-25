using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PatientManager : Singleton<PatientManager>
{
    public GameObject[] PatientGroup;
    public List<Patient> currentPatientGroup = new List<Patient>();
    public Transform startPos;
    public Transform turnPos;
    public Transform endPos;

    public void CreatPatient()
    {
        GameObject Patient = PatientGroup[Random.Range(0, PatientGroup.Length)];
        GameObject currentPatient = Instantiate(Patient, startPos.position,startPos.rotation);
        //currentPatient.transform.DOMove(turnPos.position, 2.5f).OnComplete(()=> {
        //    currentPatient.GetComponent<Animator>().SetTrigger("Turn");
        //    currentPatient.transform.DOMove(endPos.position, 2.5f).OnComplete(()=> {
        //        currentPatient.GetComponent<Animator>().SetTrigger("Idle");
        //    });
        //    Debug.Log("创建成功");
        //});
        currentPatientGroup.Add(currentPatient.GetComponent<Patient>());
    }

    private void Start()
    {
        CreatPatient();
    }
}
