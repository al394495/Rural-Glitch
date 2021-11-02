using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public GameObject Imagen;
    public GameObject boton1;
    public GameObject boton2;
    public GameObject boton3;
    public bool menuabierto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1.0f)
            {
                Time.timeScale = 0.0f;
                Imagen.SetActive(true);
                boton1.SetActive(true);
                boton2.SetActive(true);
                boton3.SetActive(true);
                menuabierto = true;
            }    
            else
            {
                Time.timeScale = 1.0f;
                Imagen.SetActive(false);
                boton1.SetActive(false);
                boton2.SetActive(false);
                boton3.SetActive(false);
                menuabierto = false;
            }
        }
    }
    
}
