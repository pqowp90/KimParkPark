using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class flag : MonoBehaviour
{
    private float rotateDegree;
    private Rigidbody2D myRigidbody2D;
    [SerializeField]
    private Collider2D myCollider2D;
    public bool isLook=false,isFloor,isHand;
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myCollider2D.enabled = !isHand;
        if(isHand){
            transform.localRotation = Quaternion.Euler(0f,0f,-142.758f);
            return;
        }
        if(isLook){
            FlagRotation();
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(isHand)return;
        isLook = false;
        isFloor = true;
        myRigidbody2D.velocity = Vector2.zero;
        transform.DORotateQuaternion(Quaternion.Euler(0f,0f,-90f),0.5f);
    }
    private void FlagRotation(){
        rotateDegree = Mathf.Atan2(myRigidbody2D.velocity.y, myRigidbody2D.velocity.x);
        transform.localEulerAngles = new Vector3(0, 0, (rotateDegree * 180) / Mathf.PI);
    }
}
