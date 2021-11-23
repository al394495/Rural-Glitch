using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonTexto : MonoBehaviour
{
    public Text text;

    public void CambiaTexto(string texto)
    {
        text.text = texto;
    }
}