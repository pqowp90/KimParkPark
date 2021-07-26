using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    [SerializeField]
    private GameObject[] wind = null;

    public void OffWind(){
        for(int i = 0 ; wind[i] == null ; i++){
            wind[i].SetActive(false);
        }
    }
}
