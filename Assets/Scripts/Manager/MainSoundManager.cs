using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSoundManager : MonoBehaviour
{


    public void SetSoundEffectVolume(float volume)
    {
        PlayerPrefs.SetFloat("Volume", volume);
    }

    
}
