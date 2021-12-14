using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonTexto : MonoBehaviour
{
    public Text numero;
    public bool activado = false;

    public Animator animacionBarrera0;
    public Animator animacionBarrera1;
    public Animator animacionBarrera2;
    public Animator animacionBarrera3;
    public Animator animacionBarrera4;
    public Animator animacionBarrera5;
    public Animator animacionBarrera6;
    public Animator animacionBarrera7;

    public Rigidbody2D Areo;
    public Rigidbody2D Pipas;
    public Rigidbody2D Doroto;
    public Rigidbody2D Mikudo;
    public Rigidbody2D Cola;
    public Rigidbody2D Faint;
    public Rigidbody2D Tidient;
    public Rigidbody2D Pring;

    public float contador = 0f;

    public int contadorMonedas = 0;

    public AudioSource Movimiento;
    public AudioSource BotonPulsar;

    public void CambiaTexto(string newNumero)
    {
        if (activado == false)
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
        
    }

    public void Sonido()
    {
        BotonPulsar.Play();
    }

    void Update()
    {

        if (contadorMonedas == 3 && (numero.text == "17" || numero.text == "18"))
        {
            activado = true;
            Cronometro();            
        }
        Debug.Log(contadorMonedas);
    }

    void Cronometro()
    {
        contador += Time.deltaTime;
        if (numero.text == "17")
        {
            animacionBarrera4.SetBool("open4", true);
            if (contador >= 1.4)
            {
                Cola.gravityScale = 1;
            }
            if (contador >= 2.4)
            {
                animacionBarrera5.SetBool("open5", true);
            }
            if (contador >= 3.8)
            {
                Faint.gravityScale = 1;
            }
        }
        else if(numero.text == "18")
        {
            animacionBarrera5.SetBool("open5", true);
            if (contador >= 1.4)
            {
                Faint.gravityScale = 1;
            }
            if (contador >= 2.4)
            {
                animacionBarrera4.SetBool("open4", true);
                Movimiento.Play();
            }
            if (contador >= 3.8)
            {
                Cola.gravityScale = 1;
            }
        }

        if (contador >= 4)
        {
            animacionBarrera2.SetBool("open2", true);
        }
        if (contador >= 4.5)
        {
            animacionBarrera7.SetBool("open7", true);
        }
        if (contador >= 5)
        {
            animacionBarrera1.SetBool("open1", true);
        }
        if (contador >= 5.5)
        {
            animacionBarrera3.SetBool("open3", true);
        }
        if (contador >= 5.2)
        {
            Doroto.gravityScale = 1;
        }
        if(contador >= 5.7)
        {
            Pring.gravityScale = 1;
        }
        if(contador >= 6.3)
        {
            animacionBarrera0.SetBool("open0", true);
            Pipas.gravityScale = 1;
        }
        if (contador >= 6.7)
        {
            Mikudo.gravityScale = 1;
            animacionBarrera6.SetBool("open6", true);
        }
        if(contador >= 7.5)
        {
            Areo.gravityScale = 1;
        }
        if(contador >= 7.9)
        {
            Tidient.gravityScale = 1;
        }
        if (contador >= 9)
        {
            VariablesGlobales.bebidasRecogidas = true;
            MainMenuScript.cambio = "maquina-tienda";
            SceneManager.LoadScene("Tienda");
        }

    }

    void PlayMovimiento()
    {
        Movimiento.Play();
    }
}
