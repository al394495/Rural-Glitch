using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerYaya : MonoBehaviour
{
    public Dialogue dialogoInicial;
    public Dialogue dialogoNoRebollons;
    public Dialogue dialogoRebollons;
    public Dialogue dialogoBebidas;

    public void TriggerDialogueYaya()
    {
        if (VariablesGlobales.dialogoYaya == 0) 
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogoInicial);
            hud.mensaje = true;
            VariablesGlobales.minijuego1 = true;
            VariablesGlobales.dialogoYaya = 1;
        }
        else if (VariablesGlobales.bebidasRecogidas == false)
        {
            if (VariablesGlobales.contadorRobellons < 5)
                FindObjectOfType<DialogueManager>().StartDialogue(dialogoNoRebollons);
            else
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogoRebollons);
                hud.mensaje = true;
                VariablesGlobales.minijuego1 = false;
                VariablesGlobales.dialogoYaya = 2;
            } 
        }
        else
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogoBebidas);
            VariablesGlobales.minijuegoRealizado2 = true;
        }
    }
}
