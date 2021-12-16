using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerVendedor : MonoBehaviour
{
    public Dialogue dialogoPrimero;
    public Dialogue dialogoMaquina;

    public void TriggerDialogueVendedor()
    {
        if (VariablesGlobales.bebidasRecogidas == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogoPrimero);
        }
        else
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogoMaquina);
            VariablesGlobales.dialogoVendedor = 1;
        }
    }
  
}
