using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour, IActive
{
    private GameObject myChild;
    void Start(){
        myChild = transform.GetChild(0).gameObject;
    }
    void IActive.Active(bool on)
    {
        myChild.SetActive(on);
        
    }
}
