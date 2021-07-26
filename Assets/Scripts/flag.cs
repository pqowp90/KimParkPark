using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag : MonoBehaviour
{
    private float rotateDegree;
    private Rigidbody2D myRigidbody2D;
    private bool isLook=false;
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isLook){
            FlagRotation();
        }
    }
    private void FlagRotation(){
        rotateDegree = Mathf.Atan2(myRigidbody2D.velocity.x,myRigidbody2D.velocity.y)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f,0f,rotateDegree-90f);
    }
}
