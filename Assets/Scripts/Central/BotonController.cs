using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonController : MonoBehaviour
{
    public GameObject Imagen;
    Animator animator;

    void Start()
    {
        animator = Imagen.GetComponent<Animator>();
    }
    public void PulsarBoton()
    {
        Debug.Log("Cinematica final");
        animator.SetBool("Pulsado", true);
        //Esperar unos segundos a que se haga la animación 
        //y saltar a cinematica final
    }
}
