using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainSoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource backgroundMusic;
    [SerializeField]
    private AudioSource soundEffect;
    [SerializeField]
    private AudioClip soundClip;

    private void Start(){
        backgroundMusic.ignoreListenerPause = true;
        backgroundMusic.Play();
    }
    public void SetSoundEffectVolume(float volume)
    {
        PlayerPrefs.SetFloat("Volume", volume);
    }
    public void SetBackgroundMusic(float volume)
    {
        backgroundMusic.volume = volume;
    }
    public void PlaySoundEffect()
    {
        Debug.Log("À×");
        soundEffect.ignoreListenerPause = true;
        soundEffect.PlayOneShot(soundClip , PlayerPrefs.GetFloat("Volume",1f));
    }

}
