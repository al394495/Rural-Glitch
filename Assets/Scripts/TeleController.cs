using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleController : MonoBehaviour
{

    public Animator anim;
    public KeyCode click;
    public int contador;

    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(click)) {

            contador++;
        }

        if (contador == 5) {

            anim.SetTrigger("TeleTrigger");
        }

    }
}
