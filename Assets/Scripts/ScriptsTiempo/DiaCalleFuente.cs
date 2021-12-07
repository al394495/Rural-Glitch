using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaCalleFuente : MonoBehaviour
{
    public GameObject Marta;
    public GameObject Josep;
    public GameObject Guillem;
    // Start is called before the first frame update
    void Start()
    {
        if (VariablesGlobales.Dia != 2)
        {
            Marta.SetActive(false);
            Josep.SetActive(false);
            Guillem.SetActive(false);
        }
        else
        {
            Marta.SetActive(true);
            Josep.SetActive(true);
            Guillem.SetActive(true);
        }
    }
}
