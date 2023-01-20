using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientManager : MonoBehaviour
{
    public GameObject[] PatientGroup;
    public Transform WalkStartPos;
    public Transform WalkEndPos;

    public void CreatPatient()
    {
        GameObject Patient = PatientGroup[Random.Range(0, PatientGroup.Length)];
        Instantiate(Patient, WalkStartPos.position,Quaternion.identity);
        Debug.Log("创建成功");
    }

    private void Start()
    {
        InvokeRepeating("CreatPatient", 0, 5);
    }
}
