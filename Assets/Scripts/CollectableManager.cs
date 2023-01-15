using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Single"))
        {
            Destroy(gameObject);
            PlayerGameController.instance.score++;
        }
    }
}
