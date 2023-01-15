using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerGameController : MonoBehaviour
{
    public float moveSpeed;
    public bool isStop = false, start = false;
    public Animator playerAnimA,playerAnimB,mergePlayerAnim;
    public GameObject playerA, PlayerB,mergePlayer;

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
                mergePlayerAnim.SetBool("isRunning", true);
                transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
            }
        }
        float distance = Vector3.Distance(playerA.transform.position, PlayerB.transform.position);

        //MERGE OLDUGUM YER
        if (distance < 0.5f)
        {
            mergePlayer.SetActive(true);

            playerA.SetActive(false);
            playerA.tag = "Merged";
            PlayerB.SetActive(false);
            PlayerB.tag = "Merged";
        }
        //SINGLE OLDUGUM YER

        if (distance > .65f)
        {
            mergePlayer.SetActive(false);

            playerA.SetActive(true);
            playerA.tag = "Single";
            PlayerB.SetActive(true);
            PlayerB.tag = "Single";
        }
    }
}