using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteracciónMaquina : MonoBehaviour
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
                SceneManager.LoadScene("MaquinaExpendedora");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (VariablesGlobales.bebidasRecogidas == false)
        {
            Texto.SetActive(true);
            cerca = true;
        }
        else cerca = false;

    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
        cerca = false;
    }
}

