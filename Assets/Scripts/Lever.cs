using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField]
    private Transform chook;
    [SerializeField]
    private bool on , isTouch;
    private Pipe pipe;
    [SerializeField]
    private AudioSource[] audioSource;

    void Start(){
        pipe = GetComponentInChildren<Pipe>();
        audioSource[0].enabled = false;
        audioSource[1].enabled = false;
    }
    void Update()
    {
        if(chook.rotation.z>0f&&on){
            on = false;
        } if(chook.rotation.z<0f&&!on){
            on = true;
        }
        PlayMusic();
        pipe.on = on;
    }
    private void PlayMusic(){
        if(on){
            audioSource[0].enabled = true;
            audioSource[1].enabled = false;
            isTouch = true;
        }
        else {
            if(!isTouch)return;
            audioSource[1].enabled =true;
            audioSource[0].enabled = false;
        }
    }

}
