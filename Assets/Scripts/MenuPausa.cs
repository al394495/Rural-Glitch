using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject Imagen;
    public bool menuabierto = false;

    public GameObject botonchat;
    public GameObject botoninternet;
    public GameObject botonconfiguracion;
    public GameObject botonsalida;
    public GameObject botonatras;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = Imagen.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.DialogoActivo == false)
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
                    Imagen.SetActive(false);
                    botonchat.SetActive(false);
                    botoninternet.SetActive(false);
                    botonconfiguracion.SetActive(false);
                    botonsalida.SetActive(false);
                    botonatras.SetActive(false);
                    menuabierto = false;
                }


                if (animator.GetBool("Chat") == true || animator.GetBool("Internet") == true)
                {

                    animator.SetBool("Chat", false);
                    animator.SetBool("Internet", false);
                    animator.SetBool("Chat-Marta", false);
                    animator.SetBool("Vacio", false);
                }

            }
        }
    }

    public void PulsarbotonChat()
    {
        if (VariablesGlobales.minijuego1 == true)
        {
            animator.SetBool("Chat", true);
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
        animator.SetBool("Internet", true);
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
        animator.SetBool("Internet", false);
        animator.SetBool("Chat-Marta", false);
        animator.SetBool("Vacio", false);
        botonatras.SetActive(false);
        botonchat.SetActive(true);
        botoninternet.SetActive(true);
        botonconfiguracion.SetActive(true);
        botonsalida.SetActive(true);
    }

}
