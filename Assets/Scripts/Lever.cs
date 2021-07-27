using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField]
    private Transform chook;
    public bool on;
    void Start()
    {
        
    }

    void Update()
    {
        if(chook.rotation.z>0f&&on){
            on = false;
        }else if(chook.rotation.z<0f&&!on){
            on = true;
        }
    }
    void OnTriggerStay2D(Collider2D collider2D){
        collider2D.GetComponent<IActive>().Active(on);
    }
}
