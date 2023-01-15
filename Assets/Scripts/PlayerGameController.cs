using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerGameController : MonoBehaviour
{
    public float moveSpeed;
    public bool isStop = false, start = false;
    public Animator playerAnimA,playerAnimB;

    void Update()
    {
        if (!isStop)
        {
            if (Input.GetMouseButtonDown(0))
            {
                start = true;
            }
            if (start)
            {
                playerAnimA.SetBool("isRunning", true);
                playerAnimB.SetBool("isRunning", true);
                transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
            }
        }
    }
}