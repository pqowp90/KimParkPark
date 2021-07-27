using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presser : MonoBehaviour
{
    [SerializeField]
    private GameObject things;

    private IActive active;

    private void Start(){
        active = things.GetComponent<IActive>();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        active.Active(true); // on
    }
    private void OnTriggerExit2D(Collider2D collision){
        active.Active(false); // off
    }

}
