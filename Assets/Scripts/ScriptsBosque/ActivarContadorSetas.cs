using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarContadorSetas : MonoBehaviour
{
    public GameObject Contador;
    // Start is called before the first frame update
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
