using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour, IActive
{
    [SerializeField]
    private GameObject[] blue;

    private int maxBlue;
    private bool isSetActive = false;

    private void Start(){
        maxBlue = gameObject.transform.childCount;
        Active(!isSetActive);
    }
    public void Active(bool onOff)
    {
        isSetActive = !onOff;
        SetActive(isSetActive);
    }
    private void SetActive(bool onOff)
    {
        for (int i = 0; i < maxBlue; i++)
        {
            blue[i].SetActive(onOff);
        }
    }
}
