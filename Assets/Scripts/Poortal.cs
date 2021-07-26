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
        if (collision.CompareTag("PlayerHitBox"))
        {
            poortal.GetComponent<Poortal>().isPoortal = true;
            collision.gameObject.transform.parent.position = poortal.transform.position;
            Debug.Log("¿Ãµø");

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerHitBox"))
        {
            isPoortal = false;
        }
    }

}
