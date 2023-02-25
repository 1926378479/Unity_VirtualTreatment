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

    public Sprite doctorFace, patientFace;

    private void Start()
    {
        //patientFace = Patient.currentRoleFace;
        //StartCoroutine(SetTextUI(time));


    }
    private void OnEnable()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && index == textList.Count)
        {
            index = 0;
            gameObject.SetActive(false);
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("°´ÏÂ¿Õ¸ñ");
            if (textFinished && !cancelTyping)
            {
                StartCoroutine(SetTextUI(time));
            }
            else if (!textFinished)
            {
                cancelTyping = !cancelTyping;
            }

        }
    }
    IEnumerator SetTextUI(float time)
    {
        textFinished = false;
        DialogText.text = "";

        switch (textList[index])
        {
            case "Doctor":
                RoleImage.sprite = doctorFace;
                index++;
                break;
            case "Patient":
                RoleImage.sprite = patientFace;
                index++;
                break;
        }

        int letter = 0;
        while (!cancelTyping && letter < textList[index].Length - 1)
        {
            DialogText.text += textList[index][letter];
            letter++;
            yield return new WaitForSeconds(time);
        }

        DialogText.text = textList[index];
        cancelTyping = false;
        index++;
        textFinished = true;
    }
    
}
