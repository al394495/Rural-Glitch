using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class BotonController : MonoBehaviour
{
    public GameObject Imagen;
    Animator animator;

    public GameObject cinematicaFinal;
    public VideoPlayer videoFinal;

    void Start()
    {
        animator = Imagen.GetComponent<Animator>();
        cinematicaFinal.SetActive(false);
    }
    public void PulsarBoton()
    {
        Debug.Log("Cinematica final");
        animator.SetBool("Pulsado", true);
        cinematicaFinal.SetActive(true);
        videoFinal = cinematicaFinal.GetComponent<VideoPlayer>();
        videoFinal.Play();
    }
}
