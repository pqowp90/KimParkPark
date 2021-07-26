using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    [SerializeField]
    private GameObject[] things = null;
    [SerializeField]
    private int maxObjectCount;
    
    private IActive active;
    private int isOn = -1;

    private void Start(){
        Active();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")||collision.CompareTag("Flag")){
            Active();
        }
    }
    private void Active(){
        for(int i = 0 ; i < maxObjectCount; i++){
            active = things[i].GetComponent<IActive>();
            if(isOn == 1){
                active.UnActive();
                Debug.Log("À×");
            }
            else if(isOn == -1){
                active.Active();
                Debug.Log("¿Ë");
            }
        }
        isOn *= -1;
    }
}
