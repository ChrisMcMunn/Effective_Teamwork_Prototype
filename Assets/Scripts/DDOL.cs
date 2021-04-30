using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DDOL : MonoBehaviour
{
    public static DDOL instance;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Destroy(gameObject);
        }
    }
}
