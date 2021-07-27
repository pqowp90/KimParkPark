using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // ��� ��ġ �޾ƿ���
    public Transform spawnPoint;
    public static bool isTeleportation = false;
    private PlayerMove playerMove;
    void Start()
    {
        playerMove = FindObjectOfType<PlayerMove>();
    }

    void Update()
    {
        if(playerMove.isDamaged)
        {
            Teleportaion();
        }
    }
    public void Teleportaion()
    {
        if (isTeleportation) return;
        isTeleportation = true;
        Go();
    }
    private void Go()
    {
        transform.position = spawnPoint.position;
        //isTeleportation = false;
    }
}
