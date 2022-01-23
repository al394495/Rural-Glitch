using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPausa : MonoBehaviour
{
    public GameObject Imagen;
    public bool menuabierto = false;
    public static bool fintutorial = false;

    public GameObject botonchat;
    public GameObject botoninternet;
    public GameObject botonconfiguracion;
    public GameObject botonsalida;
    public GameObject botonubicacion;
    public GameObject botonatras;
    public GameObject boton0;
    public GameObject boton25;
    public GameObject boton50;
    public GameObject boton75;
    public GameObject boton100;
    public GameObject Volumen;
    public Text TextoVolumen;

    public GameObject menu_salida;

    Animator animator;
    public Animator abierto;

    // Start is called before the first frame update
    void Start()
    {
        animator = Imagen.GetComponent<Animator>();
    }


    public void PulsarHUD()
    {
        if (DialogueManager.DialogoActivo == false)
        {
            if (menuabierto == false)
            {
                abierto.SetBool("abierto", true);
                menuabierto = true;
                fintutorial = true;
                hud.mensaje = false;
            }
            else
            {
                abierto.SetBool("abierto", false);
                animator.SetBool("Chat", false);
                animator.SetBool("Chat-yaya2", false);
                animator.SetBool("Internet", false);
                animator.SetBool("Mapa", false);
                animator.SetBool("Anuncio", false);
                animator.SetBool("Chat-Marta", false);
                animator.SetBool("Chat-Marta2", false);
                animator.SetBool("Vacio", false);
                animator.SetBool("Tienda", false);
                animator.SetBool("Volumen", false);

                menuabierto = false;

            }
        }
    }

    public void PulsarbotonChat()
    {
        if (VariablesGlobales.minijuego1 == true)
        {
            animator.SetBool("Chat", true);
        }
        else if (VariablesGlobales.dia == 1 && VariablesGlobales.minijuegoRealizado2 == false && VariablesGlobales.minijuegoRealizado1)
        {
            animator.SetBool("Chat-yaya2", true);
        }
        else if(VariablesGlobales.dia == 2 && VariablesGlobales.amigos < 3)
        {
            animator.SetBool("Chat-Marta", true);
        }
        else if(VariablesGlobales.dia == 2 && VariablesGlobales.minijuegoRealizado3)
        {
            animator.SetBool("Chat-Marta2", true);
        }
        else
        {
            animator.SetBool("Vacio", true);
        }

        botonchat.SetActive(false);
        botoninternet.SetActive(false);
        botonconfiguracion.SetActive(false);
        botonsalida.SetActive(false);
        botonubicacion.SetActive(false);
        botonatras.SetActive(true);
    }

    public void PulsarBotonInternet()
    {
        if (VariablesGlobales.minijuego1 == true)
        {
            animator.SetBool("Internet", true);
        }
        else if (VariablesGlobales.minijuegoRealizado1 && VariablesGlobales.minijuegoRealizado2 == false)
        {
            animator.SetBool("Tienda", true);
        }
        else if (VariablesGlobales.dia == 2 && VariablesGlobales.amigos < 3)
        {
            animator.SetBool("Anuncio", true);
        }
        else
        {
            animator.SetBool("Vacio", true);
        }

        botonchat.SetActive(false);
        botoninternet.SetActive(false);
        botonconfiguracion.SetActive(false);
        botonsalida.SetActive(false);
        botonubicacion.SetActive(false);
        botonatras.SetActive(true);
    }

    public void PulsarBotonSalida()
    {
        menu_salida.SetActive(true);
        botonchat.SetActive(false);
        botoninternet.SetActive(false);
        botonconfiguracion.SetActive(false);
        botonsalida.SetActive(false);
        botonubicacion.SetActive(false);
    }

    public void PulsarSí()
    {
        menu_salida.SetActive(false);
        SceneManager.LoadScene("Menú");
    }

    public void PulsarNo()
    {
        menu_salida.SetActive(false);
        botonchat.SetActive(true);
        botoninternet.SetActive(true);
        botonconfiguracion.SetActive(true);
        botonsalida.SetActive(true);
        botonubicacion.SetActive(true);
    }

    public void PulsarBotonUbicacion()
    {
        animator.SetBool("Mapa", true);

        botonchat.SetActive(false);
        botoninternet.SetActive(false);
        botonconfiguracion.SetActive(false);
        botonsalida.SetActive(false);
        botonubicacion.SetActive(false);
        botonatras.SetActive(true);
    }

    public void PulsarBotonAtras()
    {
        animator.SetBool("Chat", false);
        animator.SetBool("Chat-yaya2", false);
        animator.SetBool("Internet", false);
        animator.SetBool("Mapa", false);
        animator.SetBool("Anuncio", false);
        animator.SetBool("Chat-Marta", false);
        animator.SetBool("Chat-Marta2", false);
        animator.SetBool("Vacio", false);
        animator.SetBool("Tienda", false);
        animator.SetBool("Volumen", false);
        botonatras.SetActive(false);
        botonchat.SetActive(true);
        botoninternet.SetActive(true);
        botonconfiguracion.SetActive(true);
        botonsalida.SetActive(true);
        botonubicacion.SetActive(true);
        Volumen.SetActive(false);
        boton0.SetActive(false);
        boton25.SetActive(false);
        boton50.SetActive(false);
        boton75.SetActive(false);
        boton100.SetActive(false);
    }

    public void PulsarBotonConfig()
    {
        animator.SetBool("Volumen", true);

        botonchat.SetActive(false);
        botoninternet.SetActive(false);
        botonconfiguracion.SetActive(false);
        botonsalida.SetActive(false);
        botonubicacion.SetActive(false);
        botonatras.SetActive(true);
        Volumen.SetActive(true);
        boton0.SetActive(true);
        boton25.SetActive(true);
        boton50.SetActive(true);
        boton75.SetActive(true);
        boton100.SetActive(true);

    }

    public void Volumen0()
    {
        AudioListener.volume = 0.0f;
        TextoVolumen.text = "Volumen: 0%";
    }
    public void Volumen25()
    {
        AudioListener.volume = 0.25f;
        TextoVolumen.text = "Volumen: 25%";
    }
    public void Volumen50()
    {
        AudioListener.volume = 0.50f;
        TextoVolumen.text = "Volumen: 50%";
    }
    public void Volumen75()
    {
        AudioListener.volume = 0.75f;
        TextoVolumen.text = "Volumen: 75%";
    }
    public void Volumen100()
    {
        AudioListener.volume = 1.0f;
        TextoVolumen.text = "Volumen: 100%";
    }
}
