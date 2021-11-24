using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonTexto : MonoBehaviour
{
    public Text numero;

    public void CambiaTexto(string newNumero)
    {
        numero.text = newNumero;
        
    }

    public void Prueba()
    {
        Debug.Log("Prueba");
    }
}
