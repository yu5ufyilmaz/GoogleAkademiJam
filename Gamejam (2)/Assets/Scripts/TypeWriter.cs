using TMPro;
using UnityEngine;
using System.Collections;

public class TypeWriter : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";
    private TextMeshProUGUI textMeshPro;

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i + 1);
            textMeshPro.text = currentText;
            yield return new WaitForSeconds(delay);
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        StartCoroutine(ShowText());
    }
}
