using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public float down;
    private bool isRestart = false;
    void Start()
    {
        down = 6f;
    }
    void Update()
    {
        DownThron();
        ResetTorn();
    }
    private void ResetTorn()
    {
        if(PlayerSpawn.isTeleportation)
        {
            if (isRestart) return;
            isRestart = true;
            DownThron();
            down = 6f;
        }
    }

   
    private void DownThron()
    {
        isRestart = false;
        down -= Time.deltaTime/2f;
        transform.position = new Vector3(0f, down, 0f);
    }
}
