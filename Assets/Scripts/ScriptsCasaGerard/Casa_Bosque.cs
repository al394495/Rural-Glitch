using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Casa_Bosque : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            MainMenuScript.cambio = "casaGerard-bosque";
            SceneManager.LoadScene("Bosque");
        }
    }
}
