using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorRobello : MonoBehaviour
{
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
                Debug.Log("Ha cogido: robelló");
            }
        }
    }
}
