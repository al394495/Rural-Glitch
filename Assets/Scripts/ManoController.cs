using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManoController : MonoBehaviour
{
    public Animator anim;
    public KeyCode click;

    public AudioSource golpe;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(click))
        {
            anim.SetTrigger("Trigger");
            
        }
    }

    void PlayGolpe()
    {
        golpe.Play();
    }
}
