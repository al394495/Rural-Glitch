using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    public AudioSource sonidoTexto;

    public Queue<string> sentences;

    public static bool DialogoActivo = false;

    public GameObject bocadillo;
    public GameObject bocadillo2;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        DialogoActivo = true;

        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        //sonidoTexto.Play();
        if (sentences.Count == 0)
        {
            EndDialogue();
            return; 
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return StartCoroutine(WaitFor.Frames(1));
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);

        DialogoActivo = false;
        if (VariablesGlobales.minijuegoRealizado2 == true)
        {
            bocadillo.SetActive(true);

        }
        if (VariablesGlobales.dialogoMarta == 1)
        {
            bocadillo2.SetActive(true);
        }

    }


}

public static class WaitFor
{
    public static IEnumerator Frames(int frameCount)
    {
        while (frameCount > 0)
        {
            frameCount--;
            yield return null;
        }
    }
}
