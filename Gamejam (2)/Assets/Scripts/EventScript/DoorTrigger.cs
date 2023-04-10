using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject trigObject;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            trigObject.SendMessage("DoorSituation");
            Debug.Log("triggerlaniyoring");

        }
    }
}
