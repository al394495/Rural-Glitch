using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public static string cambio = "inicio-casaYaya";
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
