using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInstrucciones : MonoBehaviour
{
    public void Volver()
    {
        SceneManager.LoadScene("Menú");
    }
}
