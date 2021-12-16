using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject Imagen;
    public bool menuabierto = false;
    public static bool fintutorial = false;

    public GameObject botonchat;
    public GameObject botoninternet;
    public GameObject botonconfiguracion;
    public GameObject botonsalida;
    public GameObject botonatras;

    Animator animator;
    public Animator abierto;

    //public GameObject tutorial;
    // Start is called before the first frame update
    void Start()
    {
        animator = Imagen.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (DialogueManager.DialogoActivo == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (menuabierto == false)
                {
                    Imagen.SetActive(true);
                    botonchat.SetActive(true);
                    botoninternet.SetActive(true);
                    botonconfiguracion.SetActive(true);
                    botonsalida.SetActive(true);
                    menuabierto = true;
                    hud.mensaje = false;
                }
                else
                {
                    animator.SetBool("Chat", false);
                    animator.SetBool("Internet", false);
                    animator.SetBool("Chat-Marta", false);
                    animator.SetBool("Vacio", false);
                    Imagen.SetActive(false);
                    botonchat.SetActive(false);
                    botoninternet.SetActive(false);
                    botonconfiguracion.SetActive(false);
                    botonsalida.SetActive(false);
                    botonatras.SetActive(false);
                    menuabierto = false;
                }
            }
        }*/
        /*if (fintutorial)
        {
            tutorial.SetActive(false);
        }*/
    }

    public void PulsarHUD()
    {
        if (DialogueManager.DialogoActivo == false)
        {
            if (menuabierto == false)
            {
                /*Imagen.SetActive(true);
                botonchat.SetActive(true);
                botoninternet.SetActive(true);
                botonconfiguracion.SetActive(true);
                botonsalida.SetActive(true);*/
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
                /*Imagen.SetActive(false);
                botonchat.SetActive(false);
                botoninternet.SetActive(false);
                botonconfiguracion.SetActive(false);
                botonsalida.SetActive(false);
                botonatras.SetActive(false);*/
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
            animator.SetBool("Mapa", true);
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
        botonatras.SetActive(true);
    }

    public void PulsarBotonSalida()
    {
        SceneManager.LoadScene("Menú");
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
        botonatras.SetActive(false);
        botonchat.SetActive(true);
        botoninternet.SetActive(true);
        botonconfiguracion.SetActive(true);
        botonsalida.SetActive(true);
    }

}
