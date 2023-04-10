using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int maxHealth = 3;

    public int currentHealth;

    public GameObject endObject;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    public void ApplyDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            endObject.SendMessage("EndSituation");
            Destroy(gameObject);
        }
    }
}
