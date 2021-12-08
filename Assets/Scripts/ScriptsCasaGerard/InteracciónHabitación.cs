using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracciónHabitación : MonoBehaviour
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
                if (VariablesGlobales.minijuegoRealizado1 == true && VariablesGlobales.minijuegoRealizado2 == true)
                {
                    VariablesGlobales.dia = 2;
                    Debug.Log(VariablesGlobales.dia);
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Texto.SetActive(true);
        cerca = true;

    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
        cerca = false;
    }
}
