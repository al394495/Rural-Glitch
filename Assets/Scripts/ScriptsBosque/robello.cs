using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class robello : MonoBehaviour {


    [SerializeField]
    private Text pickUpText;

    private bool pickUpAllowed;
   
    
    public Text ContadorRobello;
    public static GameObject robelloPorCoger;

    public AudioSource setaSonido;

    public GameObject Menu;

    // Use this for initialization
    private void Start()

    {
        ContadorRobello.text = VariablesGlobales.contadorRobellons.ToString();
        pickUpText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.Space) && Menu.GetComponent<MenuPausa>().menuabierto == false)
        {
            setaSonido.Play();

            VariablesGlobales.contadorRobellons++;
            
            ContadorRobello.text = VariablesGlobales.contadorRobellons.ToString();
            PickUp(robelloPorCoger);
        }
            
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Collectible")
        {
            robelloPorCoger = collision.gameObject;
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
            
            
        }
        

    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Collectible")
        { 
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
            
        }
        

    }

    private void PickUp(GameObject borrar)
    {

        Destroy(borrar.gameObject);
    }


}