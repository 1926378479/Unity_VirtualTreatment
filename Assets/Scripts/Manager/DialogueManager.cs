using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : Singleton<DialogueManager>
{
    public Image RoleImage;
    public Text DialogText;

    public List<string> textList = new List<string>();
    int index = 0;
    public float time;
    bool textFinished = true;
    bool cancelTyping = false;
    bool isWait = false;

    public Sprite doctorFace, patientFace;
    public InputField userInput;

    private void Start()
    {
        DoctorSay();
    }
    private void OnEnable()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && index == textList.Count)
        {
            //index = 0;
            //gameObject.SetActive(false);
            //UIManager.Instance.curePanel.SetActive(true);
            //return;
        }
        if (Input.GetKeyDown(KeyCode.Space)&&!isWait)
        {
            DoctorSay();
        }
    }
    //IEnumerator SetTextUI(float time)
    //{
    //    textFinished = false;
    //    DialogText.text = "";

    //    switch (textList[index])
    //    {
    //        case "Doctor":
    //            RoleImage.sprite = doctorFace;
    //            DialogText.gameObject.SetActive(false);
    //            userInput.gameObject.SetActive(true);
    //            index++;

    //            break;
    //        case "Patient":
    //            RoleImage.sprite = patientFace;
    //            DialogText.gameObject.SetActive(true);
    //            userInput.gameObject.SetActive(false);
    //            index++;
    //            break;
    //    }

    //    int letter = 0;
    //    while (!cancelTyping && letter < textList[index].Length - 1)
    //    {
    //        DialogText.text += textList[index][letter];
    //        letter++;
    //        yield return new WaitForSeconds(time);
    //    }

    //    DialogText.text = textList[index];
    //    cancelTyping = false;
    //    index++;
    //    textFinished = true;
    //}
    public void DoctorSay()
    {
        RoleImage.sprite = doctorFace;
        userInput.interactable = true;
        userInput.text = "";
        //DialogText.gameObject.SetActive(false);
        //userInput.gameObject.SetActive(true);
    }
    public void GetPatientAnswer(string _callback)
    {
        isWait = false;
        textList.Add(_callback);
        //DialogText.text = _callback;
        RoleImage.sprite = patientFace;
        //DialogText.gameObject.SetActive(true);
        //userInput.gameObject.SetActive(false);
        userInput.text = _callback;
    }
    public void EndInput()
    {
        Debug.Log("´¥·¢");
        userInput.interactable = false;
        isWait = true;
        GptTurboScript.Instance.StartPostData(userInput.text, GetPatientAnswer);
        textList.Add(userInput.text);
    }
}
