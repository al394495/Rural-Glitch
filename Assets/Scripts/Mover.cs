using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mover : MonoBehaviour
{

    private bool estaMoviendose;
    public GameObject Moneda;
    public static int contador = 0;

    public void OnMouseDown()
    {
        estaMoviendose = true;
    }

    public void OnMouseUp()
    {
        estaMoviendose = false;
    }


    void Update()
    {
        if (estaMoviendose)
        {
            Vector2 posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(posicionRaton);
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Moneda.GetComponent<Renderer>().enabled = false;
        contador++;
    }
}
