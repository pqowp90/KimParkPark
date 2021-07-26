using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanCode : MonoBehaviour
{
    private float radian,rotateDegree,x,y;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D collider2D){
        if(collider2D.transform.parent==null)return;
        if(collider2D.transform.parent.GetComponent<Rigidbody2D>()==null)return;
        Rigidbody2D rigid = collider2D.transform.parent.GetComponent<Rigidbody2D>();
        rotateDegree = transform.eulerAngles.z+90f;
        radian = rotateDegree*Mathf.PI/180f;
        x =Mathf.Cos(radian);
        y =Mathf.Sin(radian);
        rigid.AddForce(new Vector2(x,y)*Time.deltaTime*10000f);
        rigid.velocity = new Vector2(Mathf.Clamp(rigid.velocity.x,-5f,5f),Mathf.Clamp(rigid.velocity.y,-5f,5f));
    }
}
