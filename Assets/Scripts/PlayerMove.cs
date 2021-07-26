using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    private float horizonXM,hori,Xrate;
    [SerializeField]
    private float speed,jumpPower,bottomchkDistance,jumpMaxTime,jumpingTime,rotateDegree,x,y,radian;
    private Rigidbody2D myRigidbody2D;
    [SerializeField]
    private Transform bottomChk;
    public bool isGround,isJumping,isBack;
    private Vector2 oPosition;
    [SerializeField]
    private GameObject flagPrefab;
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
        BottomChk();
        HeadRotation(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        if(Input.GetKeyDown(KeyCode.W)){
            Throwing();
        }
    }
    private void HeadRotation(Vector2 target){
        oPosition = transform.position;
        rotateDegree = Mathf.Atan2(target.y - oPosition.y, target.x - oPosition.x)*Mathf.Rad2Deg;
        
    }
    private void Throwing(){
        radian = rotateDegree*Mathf.PI/180f;
        x =Mathf.Cos(radian);
        y =Mathf.Sin(radian);
        GameObject flag = Instantiate(flagPrefab);
        flag.transform.position = transform.position;
        flag.transform.rotation = Quaternion.Euler(0f,0f,rotateDegree);
        flag.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        flag.GetComponent<Rigidbody2D>().velocity = new Vector2(x*10f,y*10f);
        flag.GetComponent<flag>().isLook=true;

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

}
