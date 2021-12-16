using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerEmo : MonoBehaviour
{
    public Dialogue dialogoPrimero;
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogoPrimero);
    }
}

