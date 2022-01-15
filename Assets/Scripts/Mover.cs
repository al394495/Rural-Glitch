using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mover : MonoBehaviour
{

    private bool estaMoviendose;
    public BotonTexto BotonTexto;

    public AudioSource coin;

    public void OnMouseDown()
    {
        estaMoviendose = true;
    }

    public void OnMouseUp()
    {
        estaMoviendose = false;
    }

    void Start()
    {
        BotonTexto = GameObject.FindWithTag("GameController").GetComponent<BotonTexto>();
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
        if (other.name == "TragaMonedas"){
            coin.Play();
            Destroy(this.gameObject);
            BotonTexto.contadorMonedas++;
        }
        
    }
}
