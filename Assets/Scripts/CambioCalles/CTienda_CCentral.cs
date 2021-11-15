using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CTienda_CCentral : MonoBehaviour
{
    public GameObject Texto;

    void OnTriggerEnter2D(Collider2D other)
    {
        Texto.SetActive(true);

    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
    }
}
