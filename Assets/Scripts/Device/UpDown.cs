using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour, IActive
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float y;

    private Rigidbody2D myRigidbody;

    private void Awake()
    {
        if (!myRigidbody) myRigidbody = GetComponent<Rigidbody2D>();
    }
    public void Active()
    {
        Debug.Log(myRigidbody.velocity.y + speed);
        //myRigidbody.velocity += new Vector2(myRigidbody.velocity.x, myRigidbody.velocity.y + speed);
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x , transform.position.y+1f), 1f);
        //transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    public void UnActive()
    {
        Debug.Log(myRigidbody.velocity.y+ speed);
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x , transform.position.y-1f), 1f);
        //transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

}
