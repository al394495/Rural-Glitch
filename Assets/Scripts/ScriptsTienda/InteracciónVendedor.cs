using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracciónVendedor : MonoBehaviour
{
    public GameObject Texto;
    public bool cerca = false;
    public bool dialogo = false;
    public GameObject Menu;



    void Update()
    {
        if (cerca)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false && DialogueManager.DialogoActivo == false)
            {
                FindObjectOfType<DialogueTriggerVendedor>().TriggerDialogueVendedor();
                dialogo = true;
            }
        }

        if (dialogo && Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (VariablesGlobales.dialogoVendedor == 0)
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
    }
}
