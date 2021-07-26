using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poortal : MonoBehaviour
{
    [SerializeField]
    private GameObject poortal = null;

    public bool isPoortal = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPoortal) return;
        if (collision.CompareTag("PlayerHitBox")||collision.CompareTag("Flag"))
        {
            poortal.GetComponent<Poortal>().isPoortal = true;
            if(collision.gameObject.transform.parent == null){
                collision.gameObject.transform.position = poortal.transform.position;
            }
            else{
                collision.gameObject.transform.parent.position = poortal.transform.position;
            }
            Invoke("PoortalExit" , 0.1f);

        }
    }
    private void PoortalExit()
    {
        isPoortal = false;
        poortal.GetComponent<Poortal>().isPoortal = false;
    }

}
