using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextSong : MonoBehaviour
{
    public AudioClip music;
    public AudioClip gameMusic;

    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        GetComponent<AudioSource>().clip = music;
        GetComponent<AudioSource>().Play();
    }

    public void playMusic(string name)
    {
        Debug.Log("Load " + name + " Level");
        SceneManager.LoadScene(name);
        if (name == "Game_Level")
        {
            GetComponent<AudioSource>().clip = gameMusic;
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().clip = music;
            GetComponent<AudioSource>().Play();
        }
    }
}
