using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField]
    private Transform chook;
    [SerializeField]
    private bool on;
    private Pipe pipe;


    void Start(){
        pipe = GetComponentInChildren<Pipe>();
    }
    void Update()
    {
        if(chook.rotation.z>0f&&on){
            on = false;
        } if(chook.rotation.z<0f&&!on){
            on = true;
        }
        pipe.on = on;

        
    }
    
}
