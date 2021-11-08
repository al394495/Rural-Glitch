using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CambioEscena : MonoBehaviour
{
    public GameObject yaya;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && yaya.GetComponent<InteraccionYaya>().dialogo == true)
        {
            SceneManager.LoadScene("Bosque"); 
        }
    }

}
