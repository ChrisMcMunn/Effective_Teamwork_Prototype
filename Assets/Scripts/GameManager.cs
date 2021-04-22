using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.Text;

public class GameManager : MonoBehaviour

{
    public static GameManager instance;
    public int HeadIndex;
    public int TorsoIndex;
    public int LegIndex;


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

    public void LoadLevel(string name)
    {
        Debug.Log("Load " + name + " Level");
        SceneManager.LoadScene(name);
    }

    public void restartCurrentScene()
    {
        StartCoroutine(reload());
    }
    private IEnumerator reload()
    {
        yield return new WaitForSecondsRealtime(1);
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void QuitLevel(string name)
    {
        Debug.Log("Quit the Application");
        Application.Quit();
    }
    public void SoundFXs(AudioClip name)
    {
        GetComponent<AudioSource>().PlayOneShot(name, 1f);
    }
}
