using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public GameObject Imagen;
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
                menuabierto = true;
            }    
            else
            {
                Time.timeScale = 1.0f;
                Imagen.SetActive(false);
                menuabierto = false;
            }
        }
    }
    
}
