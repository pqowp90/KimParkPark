using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public float down;
    void Start()
    {
        down = transform.position.y;
    }

    void Update()
    {
        DownThron();
    }
    private void DownThron()
    {
        down -= Time.deltaTime/2f;
        transform.position = new Vector3(transform.position.x, down,transform.position.z);
    }
}
