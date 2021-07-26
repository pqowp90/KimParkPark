using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    private float horizonXM,hori,Xrate;
    [SerializeField]
    private float speed,jumpPower,bottomchkDistance,jumpMaxTime,jumpingTime;
    private Rigidbody2D myRigidbody2D;
    [SerializeField]
    private Transform bottomChk;
    public bool isGround,isJumping,isBack;
    public GameObject Player;
    private float currentVelocity = 0;
    public float fallDistance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        fallDamage();
    }
    private void Jump(){
        if(Input.GetKeyDown(KeyCode.Space)&&isGround){
            isJumping=true;
            jumpingTime=0f;
        }
        if(isJumping)
            jumpingTime+=Time.deltaTime;
        if(Input.GetKey(KeyCode.Space)&&isJumping&&jumpingTime<jumpMaxTime){
            myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x,jumpPower-jumpingTime*7f);
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            isJumping=false;
            jumpingTime=0f;
        }
    }
    void BottomChk(){
        Debug.DrawRay(bottomChk.position, ((isBack)?Vector3.right:Vector3.left)*bottomchkDistance, Color.blue);
		isGround = Physics2D.Raycast(bottomChk.position,((isBack)?Vector3.right:Vector3.left) * bottomchkDistance, bottomchkDistance);
    }
    private void Move(){
        hori = Input.GetAxisRaw("Horizontal");
        if(hori==0){
            Xrate = 9f;
        }else{
            Xrate = 3f;
            isBack = (hori>0);
            transform.rotation = Quaternion.Euler(0f,(isBack)?0f:180f,0f);
        }
        horizonXM = Mathf.Lerp(horizonXM,hori*speed,Time.deltaTime*Xrate);
        myRigidbody2D.velocity=new Vector2(horizonXM,
            myRigidbody2D.velocity.y);
    }
    private void fallDamage()
    {
        BottomChk();
        if(isGround)
        {
            if(currentVelocity<-fallDistance)
            {
                Debug.Log("낙뎀을 받았다!!");
            }
            currentVelocity = 0;
        }
        else
        {
            currentVelocity = myRigidbody2D.velocity.y;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Thorn"))
        {
            Debug.Log("가시에 닿았어");
            Player.SetActive(false);
        }
    }

}
