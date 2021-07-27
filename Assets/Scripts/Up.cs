using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    public float up;
    void Start()
    {
        up = transform.position.y;
    }

    void Update()
    {
        UPThorn();
    }
    private void UPThorn()
    {
        up += Time.deltaTime / 2f;
        transform.position = new Vector3(transform.position.x, up, transform.position.z);
    }
}
