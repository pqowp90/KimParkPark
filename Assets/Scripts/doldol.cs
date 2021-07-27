using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doldol : MonoBehaviour,IActive
{
    private float myRotation;
    [SerializeField]
    private float speed;
    public bool on;
    void Start(){
        myRotation = transform.eulerAngles.z;
    }
    void Update(){
        if(on){
            myRotation+=Time.deltaTime*speed;
            transform.rotation = Quaternion.Euler(0f,0f,myRotation);
        }
    }
    void IActive.Active(bool onon)
    {
        this.on = onon;
    }
}
