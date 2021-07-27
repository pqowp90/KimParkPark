using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public bool on;
    private IActive active;

    
    void OnTriggerStay2D(Collider2D collider2D){
        active=collider2D.GetComponent<IActive>();
        if(active==null){
            active = collider2D.transform.parent.GetComponent<IActive>();
            if(active==null){
                return;
            }
        }
        active.Active(on);
    }

    
}
