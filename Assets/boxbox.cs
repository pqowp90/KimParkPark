using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxbox : MonoBehaviour
{
    private Flag Flag;
    private bool ohses;
    void Start()
    {
        Flag = FindObjectOfType<Flag>();
    }

    void Update()
    {
        transform.position = Flag.transform.position;
    }
    void OnTriggerEnter2D(Collider2D collider2D){
        
        ohses = true;
        Invoke("Chkchk",1f);
        

            
    }
    void Chkchk(){
        if(ohses){
            Flag.SetPoint();
        }
    }
    void OnTriggerExit2D(Collider2D collider2D){
        
        ohses = false;
        
    }
}
