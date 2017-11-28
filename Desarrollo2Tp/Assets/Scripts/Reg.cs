﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reg : MonoBehaviour {
    [SerializeField]
    private AudioClip Modo1Song;
    [SerializeField]
    private AudioClip Modo2Song;
    [SerializeField]
    private AudioClip Modo3Song;
    private AudioSource aud;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        aud = GetComponent<AudioSource>();
    }
    public void ChangeScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
        if (nameScene == "Menu")
        {
            Destroy(gameObject);
        }
        if (nameScene == "Game")
        {
            aud.clip = Modo1Song;
            aud.Play();
        }
        if (nameScene == "Game2")
        {
            aud.clip = Modo2Song;
            aud.Play();
        }
        if (nameScene == "Game3")
        {
            aud.clip = Modo3Song;
            aud.Play();
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            ChangeScene("Menu");
            Destroy(gameObject);
        }
        if (Input.GetButton("Reset"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
