using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionYaya : MonoBehaviour
{
    public GameObject Texto;

    void OnTriggerEnter2D(Collider2D other)
    {
        Texto.SetActive(true);
        if (Input.GetKeyDown(KeyCode.J))
            GetComponent<DialogueTrigger>().TriggerDialogue();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Texto.SetActive(false);
    }
}
