using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static T Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = (T)this;
        }
        else
        {
            Destroy(Instance.gameObject);
            Instance = (T)this;
        }
    }
}
