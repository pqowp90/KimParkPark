using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour , IActive
{
    [SerializeField]
    private GameObject[] wind = null;

    public void UnActive(){
        Debug.Log("¾Æ¹«Æ° ²¨Áü");
        // for(int i = 0 ; wind[i] == null ; i++){
        //     wind[i].SetActive(false);
        // }
    }
    public void Active(){
        Debug.Log("¾Æ¹«Æ° ÄÑÁü");
    }
}
