using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject winPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Merge") || other.gameObject.CompareTag("Single"))
        {
            PlayerGameController.instance.moveSpeed = 0;

            PlayerGameController.instance.playerAnimA.SetBool("isSingleWin", true);
            PlayerGameController.instance.playerAnimB.SetBool("isSingleWin", true);
            PlayerGameController.instance.mergePlayerAnim.SetBool("isWin", true);

            winPanel.SetActive(true);
        }
    }
}
