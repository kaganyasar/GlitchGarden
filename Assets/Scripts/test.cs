using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("start "+PlayerPrefsManager.getMasterVolume());
        PlayerPrefsManager.setMasterVolume(0.9f);
        print("later "+PlayerPrefsManager.getMasterVolume());

        print(PlayerPrefsManager.isLevelUnlocked(2));
        PlayerPrefsManager.unlockLevel(2);
        print(PlayerPrefsManager.isLevelUnlocked(2));

        print(PlayerPrefsManager.getDifficulty());
        PlayerPrefsManager.setDifficulty(12f);
        print(PlayerPrefsManager.getDifficulty());
    }

    // Update is called once per frame
    void Update () {
		
	}
}
