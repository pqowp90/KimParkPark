using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poortal : MonoBehaviour
{
    [SerializeField]
    private GameObject poortal = null;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("PlayerHitBox")){
            collision.gameObject.transform.position = poortal.transform.position;
        }
    }
    private void OnTriggerExit2D(Collider2D collilsion){
        
    }
}
