using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Merge") || other.gameObject.CompareTag("Single"))
        {
            transform.GetComponent<BoxCollider>().isTrigger = false;
            FailAction();
        }
    }
    void FailAction()
    {
        PlayerGameController.instance.playerAnimA.SetBool("isFail", true);
        PlayerGameController.instance.playerAnimB.SetBool("isFail", true);
        PlayerGameController.instance.mergePlayerAnim.SetBool("isFail", true);
        PlayerGameController.instance.moveSpeed = 0;
    }
}
