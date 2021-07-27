using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanCode : MonoBehaviour, IActive
{
    private float radian, rotateDegree, x, y;
    public bool on;
    public GameObject distans;


    [SerializeField]
    private GameObject[] onOnOn = new GameObject[2];
    private Animator myAnimator;
    [SerializeField]
    private ParticleSystem sujunggi;
    [SerializeField]
    private float force = 5f;
    [SerializeField]
    private AudioSource audioSource;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
        audioSource.enabled = false;
    }

    void Update()
    {
        sujunggi.startLifetime = distans.transform.localScale.y * 0.13f;
        for (int i = 0; i < onOnOn.Length; i++)
        {
            onOnOn[i].SetActive(on);
            //PlayMusic();
        }
        myAnimator.SetBool("IsOn", on);
        if (sujunggi.isPlaying && !on)
        {
            sujunggi.Stop();
        }
        else if (!sujunggi.isPlaying && on)
        {
            sujunggi.Play();
        }

    }
    void OnTriggerStay2D(Collider2D collider2D)
    {

        if (collider2D.transform.parent == null || !on) return;
        if (collider2D.transform.parent.GetComponent<Rigidbody2D>() == null) return;
        Rigidbody2D rigid = collider2D.transform.parent.GetComponent<Rigidbody2D>();
        rotateDegree = transform.eulerAngles.z + 90f;
        radian = rotateDegree * Mathf.PI / 180f;
        x = Mathf.Cos(radian);
        y = Mathf.Sin(radian);
        rigid.AddForce(new Vector2(x, y) * Time.deltaTime * 2000 * force);
        rigid.velocity = new Vector2(Mathf.Clamp(rigid.velocity.x, -force, force), Mathf.Clamp(rigid.velocity.y, -5f, 5f));
    }
    void IActive.Active(bool onon)
    {
        on = onon;
    }
    //private void PlayMusic()
    //{
    //    if (on)
    //    {
    //        audioSource.enabled = true;
    //    }
    //    else
    //    {
    //        audioSource.enabled = false;
    //    }
    //}
}
