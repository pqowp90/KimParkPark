using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource backgroundMusic;

    public void SetSoundEffectVolume(float volume)
    {
        PlayerPrefs.SetFloat("Volume", volume);
    }
    public void SetBackgroundMusic(float volume){
        backgroundMusic.volume = volume;
    }

    
}
