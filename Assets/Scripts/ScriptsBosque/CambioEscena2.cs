using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            MainMenuScript.cambio = "bosque-casaYaya";
            SceneManager.LoadScene("CasaYaya");
        }
    }

}