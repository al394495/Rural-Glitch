using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hud : MonoBehaviour
{
    private float amount = 500.0f;
    public static bool mensaje = false;
    public AudioSource Vibracion;


    // Update is called once per frame
    void Update()
    {
        if (mensaje == true)
        {
            vibrar();
        }
        else
        {
            Vibracion.volume = 0f;
        }
    }

    void vibrar()
    {
        Vibracion.volume = 0.5f;
        Vector3 newPos = Random.insideUnitSphere * (Time.deltaTime * amount);
        newPos.y = transform.position.y;
        newPos.z = transform.position.z;
        transform.position = newPos;
    }

}

