using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPanel : MonoBehaviour
{
    public GameObject aboutSystem;
    public void StartBtn()
    {
        SceneManager.LoadScene(1);
        AudioManager.Instance.PlayBtnClick();
    }
    public void OpenAboutSystem()
    {
        aboutSystem.SetActive(true);
        AudioManager.Instance.PlayBtnClick();
    }
    public void CloseAboutSystem()
    {
        aboutSystem.SetActive(false);
        AudioManager.Instance.PlayBtnClick();
    }
    public void QuitBtn()
    {
        Application.Quit();
        AudioManager.Instance.PlayBtnClick();
    }
}
