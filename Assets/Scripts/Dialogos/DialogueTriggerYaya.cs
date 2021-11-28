using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerYaya : MonoBehaviour
{
    public Dialogue dialogoInicial;
    public Dialogue dialogoNoRebollons;
    public Dialogue dialogoRebollons;

    public void TriggerDialogueYaya()
    {
        if (InteraccionYaya.dialogo == false) 
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogoInicial);
            hud.mensaje = true;
        }
        else
        {
            if (robello.contadorRobellons < 5)
                FindObjectOfType<DialogueManager>().StartDialogue(dialogoNoRebollons);
            else
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogoRebollons);
                hud.mensaje = true;
            }
             
        } 
    }
}
