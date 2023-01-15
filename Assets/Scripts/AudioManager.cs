using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] GameObject unmuteButton;
    [SerializeField] GameObject muteButton;
    [SerializeField] AudioSource audioSource;

    private bool on = true;
	
    // Start is called before the first frame update
    void Start()
    {
        SetAudio();
        audioSource.Play();
    }


    public void ToggleAudio()
    {
        on = !on;
        if(on)
        {
        	audioSource.UnPause();

        }
        else
        {
        	audioSource.Pause();

        }
        SetAudio();
    }

    void SetAudio()
    {
    	unmuteButton.SetActive(on);
        muteButton.SetActive(on);

    }

}
