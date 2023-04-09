using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform firepoint;

    public GameObject bullet;

    private float timeBetween;

    public float starttimebetween;
    // Start is called before the first frame update
    void Start()
    {
        timeBetween = starttimebetween;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetween <= 0)
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            timeBetween = starttimebetween;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
    }
}
