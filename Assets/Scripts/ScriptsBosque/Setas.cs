using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setas : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText;
    [SerializeField] 
    private Image Bocadillo;
    private bool pickUpAllowed;

    public GameObject Menu;
    
    // Start is called before the first frame update
    void Start()
    {
        pickUpText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false)
        {
            Bocadillo.gameObject.SetActive(true);
        }

        if  (pickUpAllowed == false)
        {
            Bocadillo.gameObject.SetActive(false);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (VariablesGlobales.minijuego1 == true)
        {
            if (collision.gameObject.tag == "NonCollectible")
            {

                pickUpText.gameObject.SetActive(true);
                pickUpAllowed = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "NonCollectible")
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;

        }


    }


}
