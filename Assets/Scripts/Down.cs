using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public float down;
    void Start()
    {
        down = 6f;
    }

    void Update()
    {
        DownThron();
    }
    private void DownThron()
    {
        down -= Time.deltaTime/2f;
        transform.position = new Vector3(0f, down, 0f);
    }
}
