using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public GameObject Imagen;
    public bool menuabierto = false;

    public GameObject botonchat;
    public GameObject botoninternet;
    public GameObject botonconfiguracion;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = Imagen.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuabierto == false)
            {
                Imagen.SetActive(true);
                botonchat.SetActive(true);
                botoninternet.SetActive(true);
                botonconfiguracion.SetActive(true);
                menuabierto = true;
            }    
            else
            {
                Imagen.SetActive(false);
                botonchat.SetActive(false);
                botoninternet.SetActive(false);
                botonconfiguracion.SetActive(false);
                menuabierto = false;
            }

          
            if (animator.GetBool("Chat") == true || animator.GetBool("Internet") == true) {
                
                animator.SetBool("Chat", false);
                animator.SetBool("Internet", false);
            }
            
        }
    }

    public void PulsarbotonChat()
    {
        botonchat.SetActive(false);
        botoninternet.SetActive(false);
        botonconfiguracion.SetActive(false);
        animator.SetBool("Chat", true);
    }

    public void PulsarBotonInternet()
    {
        botonchat.SetActive(false);
        botoninternet.SetActive(false);
        botonconfiguracion.SetActive(false);
        animator.SetBool("Internet", true);
    }

}
