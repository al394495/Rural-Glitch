using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public static string cambio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()

    {
        cambio = "inicio-casaYaya";
        SceneManager.LoadScene("CasaYaya");
    }


    public void Instrucciones()

    {
        SceneManager.LoadScene("Instrucciones");
    }


    public void Salir()
    {
        Application.Quit();
    }
}
