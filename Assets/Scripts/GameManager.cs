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
    public GameObject TitleScreen;
    public GameObject Customize;
    public GameObject Character;
    public GameObject Map;

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
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            TitleScreen.SetActive(false);

        }

        else
        {
            TitleScreen.SetActive(true);
            Customize.SetActive(false);
            Character.SetActive(false);
            Map.SetActive(false);
        }
    }

    public void LoadLevel(string name)
    {
        Debug.Log("Load " + name + " Level");
        SceneManager.LoadScene(name);

        if (name == "Main Menu")
        {
            Customize.SetActive(false);
            Character.SetActive(false);
            TitleScreen.SetActive(true);
            Map.SetActive(false);
        }
        if (name == "Character Customization")
        {
            Customize.SetActive(true);
            Character.SetActive(true);
            TitleScreen.SetActive(false);
            Map.SetActive(false);
        }
        if(name == "Map")
        {
            Map.SetActive(true);
            Customize.SetActive(false);
            Character.SetActive(false);
            TitleScreen.SetActive(false);
        }
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
