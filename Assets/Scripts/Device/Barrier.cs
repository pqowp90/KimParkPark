using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour , IActive
{
    private void OnTriggerStay2D(Collider2D collision){
        Debug.Log("dd");
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        collision.transform.position -= (transform.position - collision.transform.localPosition)*0.2f;
        collision.GetComponent<flag>().isLook = false;
        if(!collision.gameObject.GetComponentInParent<PlayerMove>())return;
        collision.gameObject.GetComponentInParent<PlayerMove>().Throwing();
        
    }
    
    public void Active(bool onOff){
        transform.GetChild(0).gameObject.SetActive(onOff);
    }
}
