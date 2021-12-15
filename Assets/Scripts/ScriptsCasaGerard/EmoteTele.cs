using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteTele : MonoBehaviour
{
    public GameObject bocadillo;
    public float tiempoIni = 0;
    public float tiempoFin = 3;

    // Update is called once per frame
    void Update()
    {
        if (MainMenuScript.cambio == "tele-casaGerard")
        {
            bocadillo.SetActive(true);
            iniciarContador();
        }
    }

    private void iniciarContador()
    {
        tiempoIni += Time.deltaTime;
        if (tiempoIni >= tiempoFin)
        {
            bocadillo.SetActive(false);
        }
    }
}
