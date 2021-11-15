using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class robello : MonoBehaviour {


    [SerializeField]
    private Text pickUpText;

    private bool pickUpAllowed;
   
    public static int contadorRobellons;
    public Text ContadorRobello;
    private Collider2D robelloPorCoger;

    // Use this for initialization
    private void Start()

    {
        
        pickUpText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {

            contadorRobellons++;
            
            ContadorRobello.text = contadorRobellons.ToString();
            PickUp(robelloPorCoger);
        }
            
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Collectible")
        {
            robelloPorCoger = collision;
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

    private void PickUp(Collider2D borrar)
    {
        //contador++;

        Destroy(borrar.gameObject);
        //ContadorRobello.text = contador.ToString();
    }


}