using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerardController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public Animator animator;
    float horizontal = 0f;

    public AudioSource paso;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        Vector2 positionIni = transform.position;

        //Controlar posicion incial de gerard en cada escena
        if (MainMenuScript.cambio == "inicio-casaYaya")
        {
            positionIni.x = -5;
            positionIni.y = -3.18f;
        }

        else if (MainMenuScript.cambio == "casaYaya-bosque")
        {
            positionIni.x = 2;
            positionIni.y = -3.18f;
        }

        else if (MainMenuScript.cambio == "bosque-casaYaya")
        {
            positionIni.x = -7.8f;
            positionIni.y = -3.18f;
        }

        else if (MainMenuScript.cambio == "bosque-casaGerard")
        {
            positionIni.x = 5.1f;
            positionIni.y = -3.49f;
        }

        else if (MainMenuScript.cambio == "casaGerard-bosque")
        {
            positionIni.x = -36;
            positionIni.y = -2.9f;
        }

        else if (MainMenuScript.cambio == "casaGerard-calleGerard")
        {
            positionIni.x = 14.54f;
            positionIni.y = -2.62f;
        }

        else if (MainMenuScript.cambio == "tele-casaGerard")
        {
            positionIni.x = 3.8f;
            positionIni.y = -3.49f;
            hud.mensaje = true;
        }

        else if (MainMenuScript.cambio == "glitches-casaGerard")
        {
            positionIni.x = -2.48f;
            positionIni.y = -3.49f;
        }

        else if (MainMenuScript.cambio == "calleGerard-casaGerard")
        {
            positionIni.x = -4.56f;
            positionIni.y = -3.49f;
        }

        else if (MainMenuScript.cambio == "calleGerard-calleFuente")
        {
            positionIni.x = 16.35f;
            positionIni.y = -3.59f;
        }

        else if (MainMenuScript.cambio == "calleFuente-calleGerard")
        {
            positionIni.x = 20.43f;
            positionIni.y = -2.62f;
        }

        else if (MainMenuScript.cambio == "calleFuente-calleTienda")
        {
            positionIni.x = -7.3f;
            positionIni.y = -3.37f;
        }

        else if (MainMenuScript.cambio == "calleTienda-calleFuente")
        {
            positionIni.x = 4.4f;
            positionIni.y = -3.59f;
        }

        else if (MainMenuScript.cambio == "calleTienda-tienda")
        {
            positionIni.x = -5f;
            positionIni.y = -3.35f;
        }

        else if (MainMenuScript.cambio == "tienda-calleTienda")
        {
            positionIni.x = -3.6f;
            positionIni.y = -3.37f;
        }

        else if (MainMenuScript.cambio == "maquina-tienda")
        {
            positionIni.x = -2.22f;
            positionIni.y = -3.35f;
        }

        else if (MainMenuScript.cambio == "calleTienda-central")
        {
            positionIni.x = -8f;
            positionIni.y = 1.8f;
        }

        transform.position = positionIni;

    }

    // Update is called once per frame
    void Update()
    {
        if (VariablesGlobales.dia == 3)
        {
            animator.SetBool("Glitched", true);
        }

        if (DialogueManager.DialogoActivo == false && VariablesGlobales.cinematica == false)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            Vector2 position = rigidbody2d.position;
            animator.SetFloat("Speed", Mathf.Abs(horizontal));
            position.x = position.x + 6.0f * horizontal * Time.fixedDeltaTime;

            rigidbody2d.MovePosition(position);

        }
        else
        {
            animator.SetFloat("Speed", Mathf.Abs(0f));
            animator.SetBool("Glitched", false);
        }




        if (horizontal > 0.0f)
        {
            transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (horizontal < 0.0f)
        {

            transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);

        }
    }

    void PlaySound()
    {
        paso.Play();
    }

}

