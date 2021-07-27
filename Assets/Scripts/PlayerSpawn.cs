using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    void Start()
    {

    }

    void Update()
    {
        
    }
    private void Go()
    {
        spawnPoint.position = transform.position;
    }
}
