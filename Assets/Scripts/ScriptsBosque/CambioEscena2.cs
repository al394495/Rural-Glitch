using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambioEscena2 : MonoBehaviour
{
    public GameObject Contador;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            MainMenuScript.cambio = "bosque-casaYaya";
            SceneManager.LoadScene("CasaYaya");
        }
    }

    void Update()
    {
        if(VariablesGlobales.minijuego1 == true && Contador.GetComponent<Text>().text != "5")
        {
            this.GetComponent<PolygonCollider2D>().isTrigger = false;
        }
        else
        {
            this.GetComponent<PolygonCollider2D>().isTrigger = true;
        }

        if (Contador.GetComponent<Text>().text == "5")
        {
            VariablesGlobales.minijuegoRealizado1 = true;
        }
    }
}