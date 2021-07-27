using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotation : MonoBehaviour
{
    private TurnFan turnFan;
    private bool islever = false;
    void Start()
    {
        turnFan = FindObjectOfType<TurnFan>();
    }

    void Update()
    {
        FanLever();
        turnFan.Angle();
    }
    private void FanLever()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, turnFan.angle));
    }
}
