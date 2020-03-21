using UnityEngine;
using UnityEngine.UI;

public class SetStartVolume : MonoBehaviour {

    //private Slider volumeSlider;
    private MusicManager musicManager;
    // Use this for initialization
    void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        if (musicManager)
        {
            float volume = PlayerPrefsManager.getMasterVolume();
            musicManager.changeVolume(volume);
        }
        else
        {
            Debug.LogWarning("No music manager found");
        }
        //volumeSlider = OptionsController.FindObjectOfType<Slider>();
        //volumeSlider.value = PlayerPrefsManager.getMasterVolume();
        //musicManager.changeVolume(volumeSlider.value);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
