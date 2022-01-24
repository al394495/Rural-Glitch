using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializarVariablesGlobales : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        VariablesGlobales.dia = 1;

        VariablesGlobales.cinematica = false;
        VariablesGlobales.cinematicaFin = false;

        VariablesGlobales.contadorRobellons = 0;


        VariablesGlobales.minijuego1 = false;
        VariablesGlobales.minijuegoRealizado1 = false;
        VariablesGlobales.minijuegoRealizado2 = false;
        VariablesGlobales.minijuegoRealizado3 = false;

        VariablesGlobales.dialogoYaya = 0;
        VariablesGlobales.dialogoVendedor = 0;
        VariablesGlobales.dialogoMarta = 0;
        VariablesGlobales.amigos = 0;

        VariablesGlobales.bebidasRecogidas = false;
    }
}
