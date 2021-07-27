using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFlag : MonoBehaviour
{
    [SerializeField]
    private GameObject[] maps;
    [SerializeField]
    private Transform endPos;

    private bool onFlag = false;
    
    private void OnTriggerEnter2D(Collider2D collision){
        int i = 0;
        if(collision.CompareTag("Flag")){
            collision.gameObject.transform.position = new Vector2(endPos.transform.position.x , endPos.transform.position.y);
            onFlag = true;
        }
        if(collision.CompareTag("PlayerHitBox")&&onFlag){
            Debug.Log("Ŭ����");
            maps[i].SetActive(false);
            i +=1;
            maps[i].SetActive(true);
        }
    }
}
