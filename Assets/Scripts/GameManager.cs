using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour

{
    public static GameManager instance;

    //void Awake()
    //{
    //    if (instance != null)
    //    {
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //}

    //void Start()
    //{
    //    if (SceneManager.GetActiveScene().buildIndex != 0)
    //    {
    //    }

    //    else
    //    {

    //    }
    //}

    public void LoadLevel(string name)
    {

        StartCoroutine(Load(name));

    }
    private IEnumerator Load(string name)
    {
        yield return new WaitForSecondsRealtime(1);
        Debug.Log("Load " + name + " Level");
        SceneManager.LoadScene(name);

        //if (name == "Main Menu")
        //{
        //    PauseMenu.SetActive(false);
        //    loseMenu.SetActive(false);
        //    TitleScreen.SetActive(true);
        //}
        //else
        //{
        //    PauseMenu.SetActive(false);
        //    loseMenu.SetActive(false);
        //    TitleScreen.SetActive(false);
        //}
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
