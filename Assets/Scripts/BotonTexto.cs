using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonTexto : MonoBehaviour
{
    public Text numero;
    public Animator animacionBarrera0;
    public Animator animacionBarrera1;
    public Animator animacionBarrera2;
    public Animator animacionBarrera3;
    public Animator animacionBarrera4;
    public Animator animacionBarrera5;
    public Animator animacionBarrera6;
    public Animator animacionBarrera7;

    public float contador = 0f;

    public void CambiaTexto(string newNumero)
    {
        if (numero.text.Length == 0)
        {
            numero.text = newNumero;
        }

        else if (numero.text.Length == 1)
        {
            numero.text += newNumero;
        }
        else
        {
            numero.text = newNumero;

        }
    }

    void Update()
    {

        if (Mover.contador == 3 && (numero.text == "17" || numero.text == "18"))
        {
            Cronometro();
            animacionBarrera0.SetBool("open0", true);
            animacionBarrera1.SetBool("open1", true);
            animacionBarrera2.SetBool("open2", true);
            animacionBarrera3.SetBool("open3", true);
            animacionBarrera4.SetBool("open4", true);
            animacionBarrera5.SetBool("open5", true);
            animacionBarrera6.SetBool("open6", true);
            animacionBarrera7.SetBool("open7", true);
            //MainMenuScript.cambio = "maquina-tienda";
            //SceneManager.LoadScene("Tienda");
        }
    }

    void Cronometro()
    {
        contador += Time.deltaTime;
    }

}
