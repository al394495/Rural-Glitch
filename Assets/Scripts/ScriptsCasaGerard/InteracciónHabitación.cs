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
    public VideoPlayer video2;

    void Start()
    {
        Cinematica2.SetActive(false);
    }
    void Update()
    {
        if (cerca)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false)
            {
                if (VariablesGlobales.minijuegoRealizado1 == true && VariablesGlobales.minijuegoRealizado2 == true)
                {
                    Cinematica2.SetActive(true);
                    video2 = Cinematica2.GetComponent<VideoPlayer>();
                    video2.Play();
                    video2.loopPointReached += CheckOver;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Texto.SetActive(true);
        cerca = true;

    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
        cerca = false;
    }

    void CheckOver(VideoPlayer vp)
    {
        VariablesGlobales.dia = 2;
        Debug.Log(VariablesGlobales.dia);
        Cinematica2.SetActive(false);
    }
}
