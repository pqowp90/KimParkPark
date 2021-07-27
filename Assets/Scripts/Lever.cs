using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField]
    private Transform chook;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = chook.position;
    }
}
