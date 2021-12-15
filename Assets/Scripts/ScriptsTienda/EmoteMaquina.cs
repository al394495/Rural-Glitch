using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteMaquina : MonoBehaviour
{
    public GameObject bocadillo;
    public float tiempoIni = 0;
    public float tiempoFin = 2;

    // Update is called once per frame
    void Update()
    {
        if(MainMenuScript.cambio == "maquina-tienda")
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
