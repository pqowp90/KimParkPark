using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxbox : MonoBehaviour
{
    private flag flag;
    private bool ohses;
    void Start()
    {
        flag = FindObjectOfType<flag>();
    }

    void Update()
    {
        transform.position = flag.transform.position;
    }
    void OnTriggerEnter2D(Collider2D collider2D){
        
        ohses = true;
        Invoke("Chkchk",1f);
        

            
    }
    void Chkchk(){
        if(ohses){
            flag.SetPoint();
        }
    }
    void OnTriggerExit2D(Collider2D collider2D){
        
        ohses = false;
        
    }
}
