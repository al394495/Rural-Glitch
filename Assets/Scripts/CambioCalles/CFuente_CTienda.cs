using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CFuente_CTienda : MonoBehaviour
{
    public GameObject Texto;
    public bool cerca = false;
    public GameObject Menu;



    void Update()
    {
        if (cerca)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false)
            {
                MainMenuScript.cambio = "calleFuente-calleTienda";
                SceneManager.LoadScene("CalleTienda");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Gerard")
        {
            Texto.SetActive(true);
            cerca = true;
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Gerard")
        {
            Texto.SetActive(false);
            cerca = false;
        }
    }
}
