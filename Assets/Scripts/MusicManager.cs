using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;

    void Awake(){
        DontDestroyOnLoad(gameObject);
        Debug.Log("Dont destroy on load: " + name);
    }
    	
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

	void OnLevelWasLoaded (int level) {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log("Playing clip: " + thisLevelMusic);

        if (thisLevelMusic) // if there's some music attached
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
	}

    public void changeVolume(float volume)
    {
        audioSource.volume = volume;
    }
}