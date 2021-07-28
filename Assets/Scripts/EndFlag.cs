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
    private int i = 0;
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Flag")){
            collision.gameObject.transform.position = new Vector2(endPos.transform.position.x , endPos.transform.position.y);
            collision.gameObject.transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            onFlag = true;
        }
        if(collision.gameObject.layer == 6&&onFlag){
            NextLevel(i);
        }
    }
    private void NextLevel(int level){
        Debug.Log("Å¬¸®¾î");
        i = level;
        maps[i].SetActive(false);
        i +=1;
        maps[i].SetActive(true);
    }
}
