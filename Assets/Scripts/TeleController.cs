using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleController : MonoBehaviour
{

    public Animator anim;
    public KeyCode click;
    public int contador;
    public float tiempoIni = 0;
    public float tiempoFin = 3;
    public bool clickon;

    // Start is called before the first frame update
    void Start()
    {
        clickon = true;
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(click) && clickon) {

            contador++;
            clickon = false;
        }

        if (contador >= 5) {

            anim.SetTrigger("TeleTrigger");
            iniciarContador();
        }

    }

    private void iniciarContador()
    {
        tiempoIni += Time.deltaTime;
        if (tiempoIni >= tiempoFin)
        {
            VariablesGlobales.minijuegoRealizado3 = true;
            MainMenuScript.cambio = "tele-casaGerard";
            SceneManager.LoadScene("CasaGerard");
        }
    }
}
