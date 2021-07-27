using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTorn : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==LayerMask.NameToLayer("Bottom"))
        {
            Debug.Log("바닥과충돌가시");

        }
    }
}
