using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botones : MonoBehaviour
{
    public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;
    public void Pulsarboton()
    {
        boton1.SetActive(false);
        boton2.SetActive(false);
        boton3.SetActive(false);
    }
}
