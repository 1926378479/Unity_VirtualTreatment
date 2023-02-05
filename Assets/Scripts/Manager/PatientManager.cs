using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PatientManager : MonoBehaviour
{
    public GameObject[] PatientGroup;
    public Transform startPos;
    public Transform turnPos;
    public Transform endPos;

    public void CreatPatient()
    {
        GameObject Patient = PatientGroup[Random.Range(0, PatientGroup.Length)];
        GameObject currentPatient = Instantiate(Patient, startPos.position,Quaternion.identity);
        currentPatient.transform.DOMove(turnPos.position, 2.5f).OnComplete(()=> {
            currentPatient.GetComponent<Animator>().SetTrigger("Turn");
            currentPatient.transform.DOMove(endPos.position, 2.5f).OnComplete(()=> {
                currentPatient.GetComponent<Animator>().SetTrigger("Idle");
            });
            Debug.Log("创建成功");
        });
    }

    private void Start()
    {
        InvokeRepeating("CreatPatient", 0, 6);
    }
}
