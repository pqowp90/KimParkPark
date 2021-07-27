// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class UpDown : MonoBehaviour, IActive
// {
//     [SerializeField]
//     private float speed;
//     [SerializeField]
//     private float y;

//     private Rigidbody2D myRigidbody;
//     private IEnumerator upBlock,downBlock;
//     private bool isMove = false;
    
//     private void Awake()
//     {
//         if (!myRigidbody) myRigidbody = GetComponent<Rigidbody2D>();
//     }
//     private void Start(){
//         upBlock = UpRigid();
//         downBlock = DownRigid();
//     }
//     public void Active()
//     {
//         isMove = true;
//         StopCoroutine(downBlock);
//         StartCoroutine(UpRigid());
//     }
//     public void UnActive()
//     {
//         isMove = true;
//         StopCoroutine(upBlock);
//         StartCoroutine(DownRigid());
//     }
//     private IEnumerator UpRigid()
//     {
//         yield return new WaitUntil(() => isMove);
//         for (int i = 0; i < 30; i++)
//         {
//             myRigidbody.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x , transform.position.y+1f), 0.1f);
//             yield return new WaitForSeconds(0.1f);
//         }
//         isMove = false;
//     }

//     private IEnumerator DownRigid()
//     {
//         yield return new WaitWhile(() => isMove);
//         for (int i = 0; i < 30; i++)
//         {
//             myRigidbody.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x , transform.position.y-1f), 0.1f);
//             yield return new WaitForSeconds(0.1f);
//         }
//         isMove = false;
//     }



// }
