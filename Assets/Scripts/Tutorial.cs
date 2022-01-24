using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject[] popUps;
    public static int popupIndex;
    public GameObject tutorial;
    public GameObject boton;

    public static bool fin = false;
    public bool click = false;
    void Update()
    {

        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popupIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }
        if(popupIndex == 0)
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                popupIndex++;
            }
        }
        else if (popupIndex == 1)
        {
            if (MenuPausa.fintutorial == true)
            {
                popupIndex++;
            }
        }
        else if (popupIndex == 2)
        {
            popUps[popupIndex].SetActive(true);
        }
        else if(popupIndex == 3)
        {
            popUps[popupIndex].SetActive(true);
        }
    }

    public void clickok()
    {
        popupIndex++;
        fin = true;
        Debug.Log("XD");
    }
}
