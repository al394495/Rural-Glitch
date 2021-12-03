using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionYaya : MonoBehaviour
{
    public GameObject Texto;
    public bool cerca = false;
    public GameObject puerta;
    public GameObject Menu;



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

        if ((VariablesGlobales.dialogoYaya1 == true && VariablesGlobales.minijuegoRealizado1 == false) || (VariablesGlobales.dialogoYaya2 == true && VariablesGlobales.minijuegoRealizado1 == true))
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
        Texto.SetActive(true);
        cerca = true;

    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
        cerca = false;
    }

}
