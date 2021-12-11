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
        contador = 0;
        clickon = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(clickon);
        if (Input.GetKeyDown(click) && clickon == true) {

            contador++;
            clickon = false;
            Debug.Log(contador);
        }

        if (contador >= 5) {

            anim.SetTrigger("TeleTrigger");
          
            iniciarContador();
        }

    }

    private void activarclick()
    {
        clickon = true;
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
