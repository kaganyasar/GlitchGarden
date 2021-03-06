﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    public float levelSeconds=5;

    private Slider slider;
    private AudioSource audioSource;
    public bool isEndOfLevel = false;
    private LevelManager levelManager;
    private GameObject winLabel;

	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();
        audioSource = GetComponent<AudioSource>();
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        findYouWon();
        winLabel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        slider.value = Time.timeSinceLevelLoad / levelSeconds;
        if (Time.timeSinceLevelLoad >= levelSeconds && !isEndOfLevel)
        {
            audioSource.Play();
            winLabel.SetActive(true);
            Invoke("LoadNextLevel", audioSource.clip.length);
            isEndOfLevel = true;
            
        }
	}
    void LoadNextLevel()
    {
        levelManager.LoadNextLevel();
    }
    void findYouWon()
    {
        winLabel = GameObject.Find("You Won");
        if (!winLabel)
        {
            Debug.LogWarning("Please create You Won object");
        }
    }
}
