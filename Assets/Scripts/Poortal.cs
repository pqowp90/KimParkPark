using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poortal : MonoBehaviour
{
    [SerializeField]
    private GameObject poortal = null;
    [SerializeField]
    private AudioSource audioSource = null;

    public bool isPoortal = false;
    private bool isMusic = false;
    
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
            isMusic = true;
            Invoke("PoortalExit" , 0.6f);
            audioSource.Play();
        }
    }
    private void PoortalExit()
    {
        isMusic = false;
        isPoortal = false;
        poortal.GetComponent<Poortal>().isPoortal = false;
    }

}
