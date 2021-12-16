using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IluminacionGlitchController : MonoBehaviour
{
    public GameObject iluminacionGlitch;
    void Update()
    {
        if (VariablesGlobales.dia == 3)
        {
            iluminacionGlitch.SetActive(true);
        }
    }
}
