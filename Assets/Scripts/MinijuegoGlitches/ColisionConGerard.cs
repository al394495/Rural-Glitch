using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionConGerard : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Gerard")
        {
            //Añadir mensaje de fallo
            //Añadir transición
            SceneManager.LoadScene("CasaGerard");
        }
    }
}
