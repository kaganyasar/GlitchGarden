using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider, diffSlider;
    public LevelManager levelManager;
    private MusicManager musicManager;
    
	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.getMasterVolume();
        diffSlider.value = PlayerPrefsManager.getDifficulty();
    }
	
	// Update is called once per frame
	void Update () {
        musicManager.changeVolume(volumeSlider.value);
	}

    public void saveAndExit()
    {
        PlayerPrefsManager.setMasterVolume(volumeSlider.value);
        PlayerPrefsManager.setDifficulty(diffSlider.value);
        levelManager.LoadLevel("01a Start");
    }

    public void setDefaults()
    {
        volumeSlider.value = 0.8f;
        diffSlider.value = 2f;
    }
}
