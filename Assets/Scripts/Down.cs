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
    //         Debug.Log("바닥과충돌가시");

    //     }
    // }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            Debug.Log("우하하핳");
        if (collision.gameObject.layer == 12 || collision.gameObject.layer == 6)
        {
            Debug.Log("잉");
            down = originalPos;
        }
    }
}
