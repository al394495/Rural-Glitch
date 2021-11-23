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
                }

            }
        }
    }

    public void PulsarbotonChat()
    {
        botonchat.SetActive(false);
        botoninternet.SetActive(false);
        botonconfiguracion.SetActive(false);
        botonsalida.SetActive(false);
        botonatras.SetActive(true);
        animator.SetBool("Chat", true);
    }

    public void PulsarBotonInternet()
    {
        botonchat.SetActive(false);
        botoninternet.SetActive(false);
        botonconfiguracion.SetActive(false);
        botonsalida.SetActive(false);
        botonatras.SetActive(true);
        animator.SetBool("Internet", true);
    }

    public void PulsarBotonSalida()
    {
        SceneManager.LoadScene("Menú");
    }

    public void PulsarBotonAtras()
    {
        botonatras.SetActive(false);
        botonchat.SetActive(true);
        botoninternet.SetActive(true);
        botonconfiguracion.SetActive(true);
        botonsalida.SetActive(true);
        animator.SetBool("Chat", false);
        animator.SetBool("Internet", false);
    }

}
