using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag : MonoBehaviour
{
    private float rotateDegree;
    private Rigidbody2D myRigidbody2D;
    public bool isLook=false;
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
        
        rotateDegree = Mathf.Atan2(myRigidbody2D.velocity.y, myRigidbody2D.velocity.x);
        transform.localEulerAngles = new Vector3(0, 0, (rotateDegree * 180) / Mathf.PI);
    }
}