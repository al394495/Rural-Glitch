using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionYaya : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        GerardController controller = other.GetComponent<GerardController>();

        if (controller != null)
        {
            Debug.Log("Pulsa SPACE para interactuar");
        }
    }
}
