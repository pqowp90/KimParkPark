using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    private float horizonXM,hori,Xrate;
    [SerializeField]
    private float speed,nowSpeed,jumpPower,bottomchkDistance,jumpMaxTime,jumpingTime,rotateDegree,x,y,radian;
    private Rigidbody2D myRigidbody2D;
    [SerializeField]
    private LayerMask[] g_layerMask = new LayerMask[2];
    [SerializeField]
    private Transform bottomChk;
    private Animator myAnimator;
    public bool isGround,isJumping,isBack , isDouble;
    private Vector2 oPosition;
    [SerializeField]
    private GameObject flagPrefab,hand;
    private float currentVelocity=0;
    public static GameObject _player;
    public float fallDistance = 20,flagStrength;
    public float maxPosition = 0;
    private bool isDamaged = false,isCharging,ohohFlag;
    
    private PlayerHPUI playerHpUI;
    // Start is called before the first frame update
    void Start()
    {
        _player = gameObject;
        myRigidbody2D = GetComponent<Rigidbody2D>();
        playerHpUI = FindObjectOfType<PlayerHPUI>();
        myAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        BottomChk();
        //fallDamaged();
        HeadRotation(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        FalgCharging();
        if(Input.GetKeyDown(KeyCode.F)&&ohohFlag){
            FlagPickUp();
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            if(!flagPrefab.GetComponent<flag>().isFloor){
                transform.position = flagPrefab.GetComponent<flag>().lastPos;
                return;
            }
            transform.position = flagPrefab.transform.position;
        }
    }
    private void FalgCharging(){
        if(Input.GetMouseButtonDown(0)){
            if(!flagPrefab.GetComponent<flag>().isHand)return;
            myAnimator.SetTrigger("boom");
            
            
            flagStrength = 0f;
            isCharging = true;
            myAnimator.SetBool("IsCharging",isCharging);
        }
        if(Input.GetMouseButton(0)){
            myAnimator.SetFloat("Blend",flagStrength);
            flagStrength += Time.deltaTime;
            flagStrength=Mathf.Clamp(flagStrength,0f,2f);
            isBack = (transform.position.x - Camera.main.ScreenToWorldPoint(Input.mousePosition).x<0);
            transform.rotation = Quaternion.Euler(0f,(isBack)?0f:180f,0f);
        }
        if(Input.GetMouseButtonUp(0)){
            if(!isCharging)return;
            isCharging = false;
            myAnimator.SetBool("IsCharging",isCharging);
            Throwing();
        }
    }
    private void HeadRotation(Vector2 target){
        oPosition = transform.position;
        rotateDegree = Mathf.Atan2(target.y - oPosition.y, target.x - oPosition.x)*Mathf.Rad2Deg;
        
    }
    public void Throwing(){
        if(!flagPrefab.GetComponent<flag>().isHand)return;
        radian = rotateDegree*Mathf.PI/180f;
        x =Mathf.Cos(radian);
        y =Mathf.Sin(radian);
        flagPrefab.transform.SetParent(null);
        flagPrefab.transform.position = transform.position;
        flagPrefab.transform.rotation = Quaternion.Euler(0f,0f,rotateDegree);
        flagPrefab.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        flagPrefab.GetComponent<Rigidbody2D>().velocity = new Vector2(x,y)*flagStrength*5f;
        flag flagScript = flagPrefab.GetComponent<flag>();
        flagScript.isLook=true;
        flagScript.isHand = false;
    }
    private void FlagPickUp(){
        flagPrefab.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        flagPrefab.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        flagPrefab.transform.SetParent(hand.transform);
        flagPrefab.GetComponent<flag>().isFloor = false;
        flagPrefab.GetComponent<flag>().isLook=false;
        flagPrefab.GetComponent<flag>().isHand = true;
        flagPrefab.transform.localPosition = Vector3.zero;
        flagPrefab.transform.localRotation = Quaternion.Euler(0f,0f,-142.758f);
    }
    private void Jump(){
        if(Input.GetButtonDown("Jump")&&isGround){
            isJumping=true;
            jumpingTime=0f;
        }
        if(isJumping)
            jumpingTime+=Time.deltaTime;
        if(Input.GetButton("Jump")&&isJumping&&jumpingTime<jumpMaxTime){
            myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x,jumpPower-jumpingTime*7f);
        }
        if(Input.GetButtonUp("Jump")){
            isDouble = false;
            isJumping=false;
            jumpingTime=0f;
        }
    }
    void BottomChk(){
        Debug.DrawRay(bottomChk.position, ((isBack)?Vector3.right:Vector3.left)*bottomchkDistance, Color.blue);
        if(!isDouble){
            int layerMask =  (1 << LayerMask.NameToLayer("Bottom"))+(1 << LayerMask.NameToLayer("Bottom2"));
            isGround = Physics2D.Raycast(bottomChk.position,((isBack)?Vector3.right:Vector3.left) * bottomchkDistance, bottomchkDistance,layerMask);
            // isGround = Physics2D.Raycast(bottomChk.position,((isBack)?Vector3.right:Vector3.left) * bottomchkDistance, bottomchkDistance,g_layerMask[0])||
            // Physics2D.Raycast(bottomChk.position,((isBack)?Vector3.right:Vector3.left) * bottomchkDistance, bottomchkDistance,g_layerMask[1]);
        
        }
        else{
            isGround = true;
        }

    }
    private void Move(){
        nowSpeed = speed*((!isCharging)?1f:0.1f);
        hori = Input.GetAxisRaw("Horizontal");
        if(hori==0){
            Xrate = 9f;
        }else{
            Xrate = 3f;
            isBack = (hori>0);
            transform.rotation = Quaternion.Euler(0f,(isBack)?0f:180f,0f);
        }
        horizonXM = Mathf.Lerp(horizonXM,hori*nowSpeed,Time.deltaTime*Xrate);
        myRigidbody2D.velocity=new Vector2(horizonXM,
            myRigidbody2D.velocity.y);
    }
    private void fallDamaged()
    {
        BottomChk();
        if(isGround)
        {
            if (maxPosition - transform.position.y > 10)
            {
                if (isDamaged) return;
                Debug.Log("Damage");
                isDamaged = true;
            }
            maxPosition = 0;
        }
        else
        {
            isDamaged = false;

            if (myRigidbody2D.velocity.y<0&& maxPosition<transform.position.y)
            {
                maxPosition = transform.position.y;
            }
        }
        //if (_player != null && playerHpUI != null)
        //{
        //}
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 15){
            isDouble = false;
            Debug.Log("����");
            gameObject.layer = 0;
        }
        if(collision.gameObject.layer == 9){
            ohohFlag = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 15){
            isDouble = true;
            Debug.Log("����");
        }
        if(collision.gameObject.layer == 9){
            ohohFlag = true;
        }
        if(collision.CompareTag("Thorn"))
        {
            _player.SetActive(false);
        }
    }
}
