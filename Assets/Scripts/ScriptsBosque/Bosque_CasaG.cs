using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bosque_CasaG : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            MainMenuScript.cambio = "bosque-casaGerard";
            SceneManager.LoadScene("CasaGerard");
        }
    }

    void Update()
    {
        if (VariablesGlobales.minijuego1 == true)
        {
            this.GetComponent<PolygonCollider2D>().isTrigger = false;
        }
        else
        {
            this.GetComponent<PolygonCollider2D>().isTrigger = true;
        }
    }
}
