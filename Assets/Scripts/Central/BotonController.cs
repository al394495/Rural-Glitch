using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class BotonController : MonoBehaviour
{
    public GameObject Imagen;
    public Animator animator;

    public GameObject cinematicaFinal;
    public VideoPlayer videoFinal;

    void Start()
    {
        animator = Imagen.GetComponent<Animator>();
        cinematicaFinal.SetActive(false);
    }
    
    public void PulsarBoton()
    {
        animator.SetBool("Pulsado", true);
        VariablesGlobales.cinematicaFin = true;

    }

    void CheckOver(VideoPlayer vp)
    {
        SceneManager.LoadScene("Menú");
    }

    void Cinematica()
    {
        cinematicaFinal.SetActive(true);
        videoFinal = cinematicaFinal.GetComponent<VideoPlayer>();
        videoFinal.Play();
        videoFinal.loopPointReached += CheckOver;
    }
}
