using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionYaya : MonoBehaviour
{
    public GameObject Texto;
    public bool cerca = false;
    public GameObject puerta;
    public GameObject Menu;
    public GameObject bocadillo;



    void Update()
    {
        if (cerca)
        {
            if (Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false && DialogueManager.DialogoActivo == false)
            {
                FindObjectOfType<DialogueTriggerYaya>().TriggerDialogueYaya();
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
        }

        if ((VariablesGlobales.dialogoYaya == 1 && VariablesGlobales.minijuegoRealizado1 == false) || (VariablesGlobales.dialogoYaya == 2 && VariablesGlobales.minijuegoRealizado1 == true))
        {
            puerta.GetComponent<PolygonCollider2D>().isTrigger = true;
        }
        else
        {
            puerta.GetComponent<PolygonCollider2D>().isTrigger = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(VariablesGlobales.dia == 1 && VariablesGlobales.minijuegoRealizado2 != true)
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
        bocadillo.SetActive(false);
    }

}
