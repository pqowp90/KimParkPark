using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presser : MonoBehaviour
{
    [SerializeField]
    private GameObject things;
    private void OnTriggerEnter2D(Collider2D collision){
        IActive unActive = things.GetComponent<IActive>();
        unActive.UnActive();
    }
    private void OnTriggerExit2D(Collider2D collision){
        IActive active = things.GetComponent<IActive>();
        active.Active();
    }

}
