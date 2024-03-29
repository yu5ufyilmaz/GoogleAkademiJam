using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ThrowPi : MonoBehaviour
{
    [SerializeField] private GameObject[] sayiPrefab;

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
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<PlayerHealth>().health -= 20;
            ;            Destroy(gameObject);
        }
    }

    IEnumerator FruitSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(sayiPrefab[Random.Range(0,sayiPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject,1.5f);
        }
    }
    
}
