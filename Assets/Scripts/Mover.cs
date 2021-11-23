using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    private bool estaMoviendose;
    public GameObject Moneda;

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
        Debug.Log("XD");
        Moneda.GetComponent<Renderer>().enabled = false;
    }
}
