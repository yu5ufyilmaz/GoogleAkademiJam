using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class geciyoring : MonoBehaviour
{
    public float gecisSaniyesi = 3;
    IEnumerator SayfaGecisi()
    {
        yield return new WaitForSeconds(gecisSaniyesi);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
    }

    private void Update()
    {
        StartCoroutine(SayfaGecisi());
    }
}
