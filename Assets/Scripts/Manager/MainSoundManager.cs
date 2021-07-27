using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource[] soundEffect = null;


    public void SetSoundEffectVolume(float volume)
    {
        PlayerPrefs.SetFloat("Volume", volume);
        AllVolume(volume);
    }
    private void AllVolume(float volume)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            soundEffect[i].volume = volume;
        }
    }
    
}
