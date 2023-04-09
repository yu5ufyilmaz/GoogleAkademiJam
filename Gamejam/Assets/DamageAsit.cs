using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAsit : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,4f);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().health -= 20;
            Debug.Log("triggered");
            Destroy(gameObject);
        }
    }
}