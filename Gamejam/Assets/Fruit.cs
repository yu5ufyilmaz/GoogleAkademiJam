using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Fruit : MonoBehaviour
{
    [SerializeField] private GameObject fruitPrefab;

    [SerializeField] private float secondSpawn = 2f;

    [SerializeField] private float minTras;

    [SerializeField] private float maxTras;
    private GameObject player;

    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FruitSpawn());
        player = GameObject.FindGameObjectWithTag(("Player"));

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().health -= 20;
            ;            Destroy(gameObject);
        }
    }

    IEnumerator FruitSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(fruitPrefab, position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject,1f);
        }
    }
    
}
