using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour, IActive
{
    [SerializeField]
    private GameObject[] blue;
    [SerializeField]
    private int maxBlue;

    private bool isSetActive = false;

    private void Start(){
        UnActive();
    }
    public void UnActive()
    {
        isSetActive = false;
        SetActive();
    }
    public void Active()
    {
        isSetActive = true;
        SetActive();
    }
    private void SetActive()
    {
        for (int i = 0; i < maxBlue; i++)
        {
            blue[i].SetActive(isSetActive);
        }
    }
}
