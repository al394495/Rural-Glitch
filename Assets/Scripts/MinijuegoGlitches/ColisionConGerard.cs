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
            //A�adir mensaje de fallo
            //A�adir transici�n
            SceneManager.LoadScene("CasaGerard");
        }
    }
}
