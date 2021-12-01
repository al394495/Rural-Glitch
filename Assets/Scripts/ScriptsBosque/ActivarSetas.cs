using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarSetas : MonoBehaviour
{
    public GameObject Seta;
    // Start is called before the first frame update
    void Start()
    {
        if (VariablesGlobales.minijuego1 == false)
        {
            Seta.SetActive(false);
        }
        else
        {
            Seta.SetActive(true);
        }
    }
}
