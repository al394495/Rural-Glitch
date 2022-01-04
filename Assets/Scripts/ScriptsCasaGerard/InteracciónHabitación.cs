using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class InteracciónHabitación : MonoBehaviour
{
    public GameObject Texto;
    public bool cerca = false;
    public GameObject Menu;

    public GameObject Cinematica2;
    public GameObject Cinematica3;
    public VideoPlayer video2;
    public VideoPlayer video3;


    void Start()
    {
        Cinematica2.SetActive(false);
        Cinematica3.SetActive(false);
    }
    void Update()
    {
        if (cerca)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false)
            {
                if (VariablesGlobales.minijuegoRealizado1 == true && VariablesGlobales.minijuegoRealizado2 == true)
                {
                    if (VariablesGlobales.dia == 1)
                    {
                        VariablesGlobales.cinematica = true;
                        Cinematica2.SetActive(true);
                        video2 = Cinematica2.GetComponent<VideoPlayer>();
                        video2.Play();
                        video2.loopPointReached += CheckOver;
                    }
                    else if (VariablesGlobales.dia == 2)
                    {
                        VariablesGlobales.cinematica = true;
                        Cinematica3.SetActive(true);
                        video3 = Cinematica3.GetComponent<VideoPlayer>();
                        video3.Play();
                        video3.loopPointReached += CheckOver;
                    }
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((VariablesGlobales.dia == 1 && VariablesGlobales.minijuegoRealizado2) || (VariablesGlobales.dia == 2 && VariablesGlobales.dialogoMarta == 1))
        {
            Texto.SetActive(true);
            cerca = true;
        }
        else cerca = false;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
        cerca = false;
    }

    void CheckOver(VideoPlayer vp)
    {
        if(VariablesGlobales.dia == 1)
        {
            VariablesGlobales.dia = 2;
            cerca = false;
            Texto.SetActive(false);
            hud.mensaje = true;
            Cinematica2.SetActive(false);
            VariablesGlobales.cinematica = false;
        }
        else if (VariablesGlobales.dia == 2)
        {
            VariablesGlobales.dia = 3;
            cerca = false;
            Texto.SetActive(false);
            Cinematica3.SetActive(false);
            VariablesGlobales.cinematica = false;
        }
    }
}
