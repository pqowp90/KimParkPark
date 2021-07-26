using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFlag : MonoBehaviour
{
    [SerializeField]
    private GameObject[] maps;

    private bool onFlag = false;
    
    private void OnTriggerEnter2D(Collider2D collision){
        int i = 0;
        if(collision.CompareTag("Flag")){
            onFlag = true;
            gameObject.SetActive(false);
        }
        if(collision.CompareTag("PlayerHitBox")&&onFlag){
            maps[i].SetActive(false);
            i +=1;
            maps[i].SetActive(true);
        }
    }
}
