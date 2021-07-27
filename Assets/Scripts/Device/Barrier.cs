using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour , IActive
{
    [SerializeField]
    private Transform flagPos;
    private void OnTriggerStay2D(Collider2D collision){
        if(collision.gameObject.layer == 8){
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.gameObject.transform.position = new Vector2(flagPos.position.x , flagPos.position.y);
        }
        if(!collision.gameObject.transform.parent)return;
        if(!collision.gameObject.transform.parent.GetComponent<PlayerMove>())return;
        collision.gameObject.transform.parent.GetComponent<PlayerMove>().Throwing();
    }
    
    public void Active(bool onOff){
        gameObject.SetActive(onOff);
    }
}
