using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffBlock : MonoBehaviour
{
    public bool on;
    private bool isTouch = false;
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Sprite[] sprites=new Sprite[2];
    [SerializeField]
    private AudioSource audioSource;
    private Pipe pipe;
    void Start(){
        pipe = GetComponentInChildren<Pipe>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collider2D){
        if((collider2D.gameObject.layer == 9)&&!isTouch){
            isTouch = true;
            if(on){
                on=false;
            }else{
                on = true;
            }
            PlayMusic();
            spriteRenderer.sprite = sprites[(on)?1:0];
            Invoke("OffTouch" , 0.5f);
        }
    }
    void Update(){
        pipe.on = on;
    }
    private void OffTouch(){
        isTouch = false;
    }
    private void PlayMusic(){
        if(on){
            audioSource.enabled = true;
        }
        else{
            audioSource.enabled = false;
        }
    }
    
}
