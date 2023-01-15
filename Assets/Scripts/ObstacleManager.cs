using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Merge") || other.gameObject.CompareTag("Single"))
        {
            Debug.Log("Fail");
            transform.GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
