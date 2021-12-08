using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionEmo : MonoBehaviour
{
    public GameObject Texto;
    public bool cerca = false;
    public bool dialogo = false;
    public bool interaccion = false;
    public GameObject Menu;

    void Update()
    {
        if (cerca)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false)
            {
                FindObjectOfType<DialogueTriggerEmo>().TriggerDialogue();
                dialogo = true;
                if (!interaccion)
                {
                    VariablesGlobales.amigos++;
                    interaccion = true;
                }
            }
        }

        if (dialogo && Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Texto.SetActive(true);
        cerca = true;

    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
        cerca = false;
    }
}
