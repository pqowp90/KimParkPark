using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{

    public float down;
    private float originalPos;
    

    void Start()
    {
        down = transform.position.y;
        originalPos = transform.position.y;
    }

    void Update()
    {
        DownThron();
    }
    private void DownThron()
    {
        down -= Time.deltaTime / 2f;
        transform.position = new Vector3(transform.position.x, down, transform.position.z);
    }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.layer == LayerMask.NameToLayer("Bottom"))
    //     {
    //         Debug.Log("�ٴڰ��浹����");

    //     }
    // }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 4)
        {
            down = originalPos;
        }
    }
}
