using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private bool isFinish = false;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==LayerMask.NameToLayer("Finish"))
        {
            if (isFinish) return;
            isFinish = true;
            Debug.Log("Finish");
        }
    }
}
