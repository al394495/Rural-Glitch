using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonTexto : MonoBehaviour
{
    public Text numero;

    public void CambiaTexto(string newNumero)
    {
        if (numero.text.Length == 0)
        {
            numero.text = newNumero;
        }

        else if (numero.text.Length == 1)
        {
            numero.text += newNumero;
            checkiar();
        }
        else
        {
            numero.text = "";
        }
    }

    void checkiar()
    {
        if (Mover.contador == 3 && (numero.text == "17" || numero.text == "18"))
        {
            Debug.Log("XD");
            MainMenuScript.cambio = "maquina-tienda";
            SceneManager.LoadScene("Tienda");
        }
    }

}
