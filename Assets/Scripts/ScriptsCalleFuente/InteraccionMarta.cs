using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionMarta : MonoBehaviour
{
    public GameObject Texto;
    public bool cerca = false;
    public bool dialogo = false;
    public bool interaccion = false;
    public GameObject Menu;
    public GameObject bocadillo2;

    void Update()
    {
        if (cerca)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false)
            {
                if (!VariablesGlobales.minijuegoRealizado3)
                {
                    FindObjectOfType<DialogueTriggerMarta>().TriggerDialogue();
                    dialogo = true;
                }
                else
                {
                    FindObjectOfType<DialogueTriggerAmigos>().TriggerDialogue();
                    dialogo = true;
                }
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
        if (VariablesGlobales.dialogoMarta != 1)
        {
            Texto.SetActive(true);
            cerca = true;
        }
        else cerca = false;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
        cerca = false;
        bocadillo2.SetActive(false);
    }
}
