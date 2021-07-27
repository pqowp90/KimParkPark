using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanDistansChk : MonoBehaviour
{
    private bool iswoho;
    [SerializeField]
    private FanCode fanCode;
    private float maxDistans;
    void Start()
    {
        maxDistans = transform.localScale.y;
    }

    void Update()
    {
        if(!iswoho){
            transform.localScale += Vector3.up*0.1f;
        }
        transform.localScale = new Vector3(transform.localScale.x,Mathf.Clamp(transform.localScale.y,0.1f,maxDistans),1f);
        fanCode.distans.transform.localScale = transform.localScale;
    }
    void OnTriggerStay2D(Collider2D collider2D){
        
        if(collider2D.CompareTag("Bottom")){
            transform.localScale -= Vector3.up*0.2f;
        }
        
    }
    void OnTriggerEnter2D(Collider2D collider2D){
        if(collider2D.CompareTag("Bottom")){
            iswoho = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider2D){
        if(collider2D.CompareTag("Bottom")){
            iswoho = false;
        }
    }
}
