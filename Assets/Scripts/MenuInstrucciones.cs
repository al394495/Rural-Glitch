using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInstrucciones : MonoBehaviour
{
    public AudioSource click;

    public void Volver()
    {
        click.Play();
        SceneManager.LoadScene("Menú");
    }

    public void Sonido()
    {
        click.Play();
    }
}
