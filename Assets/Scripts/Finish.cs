using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Merge") || other.gameObject.CompareTag("Single"))
        {
            PlayerGameController.instance.moveSpeed = 0;

            PlayerGameController.instance.playerAnimA.SetBool("isWin", true);
            PlayerGameController.instance.playerAnimB.SetBool("isWin", true);
            PlayerGameController.instance.mergePlayerAnim.SetBool("isWin", true);
        }
    }
}
