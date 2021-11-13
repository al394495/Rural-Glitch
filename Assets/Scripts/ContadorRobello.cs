using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contadorRobello : MonoBehaviour
{
    public Text ContadorRobello;

    private int robello = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Collectible"))
        {
            Collect(other.GetComponent<robello>());
        }
    }

    private void Collect(robello collectible)
    {
        if (collectible.Collect())
        {
            if(collectible is robello)
            {
                robello++;
                Debug.Log("Ha cogido: robelló");
            }
            UpdateGUI();
        }
    }

    private void UpdateGUI()
    {
        ContadorRobello.text = robello.ToString();       
    }
}
