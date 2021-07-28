using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presser : MonoBehaviour
{
    private Pipe pipe;

    private IActive active;
    [SerializeField]
    private AudioSource audioSource;
    private Vector3 startPos;
    private bool on;
    [SerializeField]
    private Transform hihi;

    private void Update(){
        
    }
    private void Start(){
        startPos = hihi.transform.position;
        pipe = GetComponentInChildren<Pipe>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if((collision.gameObject.layer == 9||collision.gameObject.layer == 2)&&!on){
            on = true;
            hihi.transform.position = startPos+Vector3.down*0.1f;
            MusicSound();
            audioSource.Play();
            pipe.on = on;
        }
    }
    private void OnTriggerExit2D(Collider2D collision){
        if((collision.gameObject.layer == 9||collision.gameObject.layer == 2)&&on){
            on = false;
            audioSource.Play();
            hihi.transform.position = startPos;
            pipe.on = on;
        }
    }
    private void MusicSound(){
        audioSource.volume = PlayerPrefs.GetFloat("Volume",1f);
    }

}
