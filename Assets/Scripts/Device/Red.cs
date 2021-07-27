using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour, IActive
{
    [SerializeField]
    private GameObject[] red;

    private int maxRed;
    private bool isSetActive = false;

    public void Active(bool onOff)
    {
        maxRed = gameObject.transform.childCount;
        isSetActive = onOff;
        SetActive(onOff);
    }
    private void SetActive(bool onOff)
    {
        for (int i = 0; i < maxRed; i++)
        {
            red[i].SetActive(onOff);
        }
    }
}
