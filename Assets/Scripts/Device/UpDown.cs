using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour , IActive
{
    [SerializeField]
    private float jumpSpeed;

    private Rigidbody2D myRigidbody;

    private void Start(){
        if(!myRigidbody)myRigidbody = GetComponent<Rigidbody2D>();
    }
    public void Active(){
        myRigidbody.velocity = new Vector2(myRigidbody.velocity.x , myRigidbody.velocity.y*jumpSpeed);
    }
    public void UnActive(){
        myRigidbody.velocity = new Vector2(myRigidbody.velocity.x , myRigidbody.velocity.y*jumpSpeed* -1f);
    }
    
}
