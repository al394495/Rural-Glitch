using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerYaya : MonoBehaviour
{
    public Dialogue dialogoInicial;
    public Dialogue dialogoNoRebollons;
    public Dialogue dialogoRebollons;

    void Start()
    {
        dialogoInicial.sentences = new string[] { "Texto de ejemplo", "xd" };
        dialogoNoRebollons.sentences = new string[] { "Niño traeme las setas" };
        dialogoRebollons.sentences = new string[] { "emoji dedo arriba" };
    }

    public void TriggerDialogueYaya()
    {
        if(InteraccionYaya.dialogo == false)
            FindObjectOfType<DialogueManager>().StartDialogue(dialogoInicial);
        else
            FindObjectOfType<DialogueManager>().StartDialogue(dialogoInicial);
    }
}
