using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicionFundido : MonoBehaviour
{

    public Animator animator;
    private int levelToLoad;


    public void FadeToLevel (int SceneIndex)
    {
        levelToLoad = SceneIndex;
        animator.SetTrigger("TransicionOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
