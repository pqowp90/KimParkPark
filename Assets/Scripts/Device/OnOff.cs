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
    private bool isOn = true; 
    private bool isTouch = false;
    
    // private void OnTriggerEnter2D(Collider2D collision){
    //     if(isTouch)return;
    //     if(collision.CompareTag("Player")||collision.CompareTag("Flag")){
    //         isTouch = true;
    //         Active();
    //         Debug.Log("À×");
    //         Invoke("OffTouch" , 0.5f);
    //     }
    // }
    private void OnTriggerEnter2D(Collider2D collision){
        if(isTouch)return;
        if(collision.CompareTag("Player")||collision.CompareTag("Flag")){
            Debug.Log("À×");
            isTouch = true;
            if(isOn){
                Active();
                isOn = false;
            }
            else if(!isOn){
                UnActive();
                isOn = true;
            }
            Invoke("OffTouch" , 0.5f);
        }
    }
    private void Active(){
        for(int i = 0 ; i < maxObjectCount; i++){
            active = things[i].GetComponent<IActive>();
            active.Active();
        }
    }
    private void UnActive(){
        for(int i = 0 ; i<maxObjectCount ; i++){
            active = things[i].GetComponent<IActive>();
            active.UnActive();
        }
    }
    private void OffTouch(){
        isTouch = false;
    }
    // private IEnumerator OffCol(){
    //     col.enabled = false;
    //     yield return new WaitForSeconds(0.3f);
    //     col.enabled = true;
    // }

}
