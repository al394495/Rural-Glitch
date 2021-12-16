using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteracciónPuerta : MonoBehaviour
{
    public GameObject Texto;
    public bool cerca = false;
    public GameObject Menu;



    void Update()
    {
        if (cerca)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false)
            {
                MainMenuScript.cambio = "tienda-calleTienda";
                SceneManager.LoadScene("CalleTienda");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (VariablesGlobales.dialogoVendedor == 1)
        {
            Texto.SetActive(true);
            cerca = true;
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
        cerca = false;
    }
}
