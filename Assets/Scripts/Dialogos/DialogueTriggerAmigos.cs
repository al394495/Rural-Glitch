using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerAmigos : MonoBehaviour
{
    public Dialogue primerDialogo;
    public Dialogue segundoDialogo;
    public Dialogue tercerDialogo;
    public Dialogue ultimoDialogo;
    public int dialoguillo = 0;
    public void TriggerDialogue()
    {
        if (dialoguillo == 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(primerDialogo);
            dialoguillo++;
        }
        else if(dialoguillo == 1)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(segundoDialogo);
            dialoguillo++;
        }
        else if (dialoguillo == 2)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(tercerDialogo);
            dialoguillo++;
        }
        else
        {
            FindObjectOfType<DialogueManager>().StartDialogue(ultimoDialogo);
            VariablesGlobales.dialogoMarta = 1;
        }
    }
}
