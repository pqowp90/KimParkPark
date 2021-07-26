using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    [SerializeField]
    private GameObject red = null;
    [SerializeField]
    private GameObject blue = null;

    private bool isOn = true;

    private void Start()
    {
        blue.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Flag"))
        {
            if (isOn)
            {
                red.SetActive(false);
                blue.SetActive(true);
                isOn = false;
            }
            else
            {
                red.SetActive(true);
                blue.SetActive(false);
                isOn = true;
            }
        }
    }

}
