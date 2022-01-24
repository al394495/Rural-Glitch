using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MainMenuScript : MonoBehaviour
{
    public static string cambio;

    public GameObject cinematicaInicial;
    public VideoPlayer videoInicial;
    public AudioSource click;
    public static bool play;

    // Start is called before the first frame update
    void Start()
    {
        cinematicaInicial.SetActive(false);
        play = false;
    }

    public void EscenaJuego()

    {
        play = true;
        cinematicaInicial.SetActive(true);
        videoInicial = cinematicaInicial.GetComponent<VideoPlayer>();
        videoInicial.Play();
        videoInicial.loopPointReached += CheckOver;
    }


    public void Instrucciones()

    {
        SceneManager.LoadScene("Instrucciones");
    }


    public void Salir()
    {
        Application.Quit();
    }

    public void Sonido()
    {
        click.Play();
    }

    void CheckOver (VideoPlayer vp)
    {
        cambio = "inicio-casaYaya";
        SceneManager.LoadScene("CasaYaya");
    }
}
