using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionYaya : MonoBehaviour
{
    public GameObject Texto;
    public bool cerca = false;
    public static bool dialogo = false;
    public GameObject puerta;



    void Update()
    {
        if (cerca)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                FindObjectOfType<DialogueTrigger>().TriggerDialogue();
                dialogo = true;
                puerta.GetComponent<PolygonCollider2D>().isTrigger = true;
            }
        }

        if (dialogo && Input.GetKeyDown(KeyCode.E))
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
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
