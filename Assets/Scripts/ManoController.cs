using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManoController : MonoBehaviour
{
    public Animator anim;
    public KeyCode click;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(click))

            anim.SetTrigger("Trigger");
        
    }
}