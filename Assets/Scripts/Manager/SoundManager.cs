using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource musicAudio = null;
    [SerializeField]
    private AudioSource soundEffect = null;

    private void Start()
    {
        musicAudio.ignoreListenerPause = true;
        musicAudio.Play();
    }
    public void SetMusicVolume(float volume)
    {
        PlayerPrefs.SetFloat("Volume", volume);
        musicAudio.volume = volume;
    }
    public void SetSoundEffectVolume(float volume)
    {
        PlayerPrefs.SetFloat("Volume", volume);
        soundEffect.volume = volume;
    }
    public void OnClickSoundEffect()
    {
        soundEffect.ignoreListenerPause = true;
        soundEffect.Play();
    }
}
