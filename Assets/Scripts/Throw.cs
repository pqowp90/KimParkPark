using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    [SerializeField]
    private GameObject flagPrefab = null;
    [SerializeField]
    private Transform flagPosition = null;

    public float distance = 13f;
    void Start()
    {
        
    }

    void Update()
    {
        Key();
    }
    private void F()
    {
        GameObject flag = Instantiate(flagPrefab, flagPosition.position, flagPosition.rotation);
        flag.GetComponent<Rigidbody2D>().velocity = flag.transform.right * distance;
    }
    private void Key()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            F();
        }
    }
}
