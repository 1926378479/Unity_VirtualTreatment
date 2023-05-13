using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    public AudioSource audioSource;
    public AudioClip btnClick;
    public AudioClip bookSound;
    public AudioClip win;
    public AudioClip lose;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PlayBtnClick()
    {
        audioSource.PlayOneShot(btnClick);
    }
    public void PlayBookSound()
    {
        audioSource.PlayOneShot(bookSound);
    }
    public void PlayWinSound()
    {
        audioSource.PlayOneShot(win);
    }
    public void PlayLoseSound()
    {
        audioSource.PlayOneShot(lose);
    }
}
