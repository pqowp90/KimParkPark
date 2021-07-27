using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnFan : MonoBehaviour
{
    Quaternion quaternion = Quaternion.identity;
    public float angle = 0;

    void Start()
    {

    }

    void Update()
    {
        //quaternion.eulerAngles = new Vector3(0f, 0f, 0f);
    }
    public void Angle()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0f,0f, angle));
    }
}
