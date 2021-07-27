using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private bool isFinish = false;
    //public Transform spawnPoint;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==LayerMask.NameToLayer("Finish"))
        {
            Go();
        }
    }
    private void Go()
    {
        if (isFinish) return;
        isFinish = true;
        //spawnPoint.position = transform.position;
        Debug.Log("순간이동");

    }
}
