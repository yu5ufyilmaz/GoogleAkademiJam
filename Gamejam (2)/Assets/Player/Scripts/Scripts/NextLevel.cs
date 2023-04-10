using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
   public float gecisSaniyesi = 4;
   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }
   }

   public void Next()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void Credits()
   {
      SceneManager.LoadScene("Credits");
   }

   public void Back()
   {
      SceneManager.LoadScene("Entry");
   }

    IEnumerator SayfaGecisi()
   {
      yield return new WaitForSeconds(gecisSaniyesi);
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
   }
}
