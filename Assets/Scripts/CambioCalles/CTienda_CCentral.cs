using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CTienda_CCentral : MonoBehaviour
{
    public GameObject Texto;
    public GameObject Barrera;
    public bool cerca = false;
    public GameObject Menu;

    void Update()
    {
        if (VariablesGlobales.dia == 3)
        {
            Barrera.SetActive(false);
            if (cerca)
            {
                if (Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false)
                {
                    MainMenuScript.cambio = "calleTienda-central";
                    //SceneManager.LoadScene("Central");
                    Debug.Log("Entra central");
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {       
        if (VariablesGlobales.dia == 3)
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
