using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarContador : MonoBehaviour
{
    public GameObject Contador;
    void Start()
    {
        if (VariablesGlobales.minijuego1 == false)
        {
            Contador.SetActive(false);
        }
        else
        {
            Contador.SetActive(true);
        }
    }
}
