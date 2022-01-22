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
            MainMenuScript.cambio = "glitches-casaGerard";
            SceneManager.LoadScene("CasaGerard");
        }
    }
}
