using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour, IActive
{
    [SerializeField]
    private GameObject[] red;
    [SerializeField]
    private int maxRed;

    private bool isSetActive = false;

    public void Active()
    {
        isSetActive = true;
        SetActive();
    }
    public void UnActive()
    {
        isSetActive = false;
        SetActive();
    }
    private void SetActive()
    {
        for (int i = 0; i < maxRed; i++)
        {
            red[i].SetActive(isSetActive);
        }
    }
}
