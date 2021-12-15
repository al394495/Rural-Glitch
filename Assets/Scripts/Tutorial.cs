using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject[] popUps;
    public static int popupIndex;
    public GameObject tutorial;

    public static bool fin = false;
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
                fin = true;
            }
        }
        else if(popupIndex == 2)
        {
            popUps[popupIndex].SetActive(true);
        }

        
    }
}
