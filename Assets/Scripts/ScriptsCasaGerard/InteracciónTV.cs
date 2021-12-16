using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteracciónTV : MonoBehaviour
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
                SceneManager.LoadScene("Tele");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((VariablesGlobales.amigos == 3 && VariablesGlobales.dia == 2) && !VariablesGlobales.minijuegoRealizado3)
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
