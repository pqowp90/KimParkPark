using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    private float radian,x,y , rotateDegree;

    private Rigidbody2D objectRigidbody2D;
    private void Start(){
        rotateDegree = transform.rotation.z;
        radian = rotateDegree*Mathf.PI/180f;
        x = Mathf.Cos(radian);
        y = Mathf.Sin(radian);
    }
    
    
    private void OnTriggerStay2D(Collider2D collision){
        if(collision.gameObject.transform.parent == null){
           objectRigidbody2D = collision.gameObject.transform.GetComponent<Rigidbody2D>();
        }
        else{
            objectRigidbody2D = collision.gameObject.transform.parent.GetComponent<Rigidbody2D>();
        }
       objectRigidbody2D.velocity = new Vector2(objectRigidbody2D.velocity.x * x * 3f, objectRigidbody2D.velocity.y * y* 3f);
    }
}
