using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFlag : MonoBehaviour
{
    [SerializeField]
    private GameObject[] maps;
    [SerializeField]
    private Transform endPos;
    private maps mapsmaps;

    private bool onFlag = false;
    private int i = 0;
    private void Update(){
        mapsmaps = FindObjectOfType<maps>();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Flag")){
            collision.gameObject.transform.position = new Vector2(endPos.transform.position.x , endPos.transform.position.y);
            //collision.gameObject.transform.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            onFlag = true;
        }
        if(collision.gameObject.layer == 6&&onFlag){
            NextLevel(i);
        }
    }
    private void NextLevel(int level){
        mapsmaps.transform.GetChild(mapsmaps.progress).gameObject.SetActive(false);
        mapsmaps.progress+=1;
        mapsmaps.transform.GetChild(mapsmaps.progress).gameObject.SetActive(true);
        Debug.Log("d");

        
    }
}
