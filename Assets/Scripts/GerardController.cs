using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerardController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public Animator animator;
    float horizontal = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.DialogoActivo == false)
        {
            
            horizontal = Input.GetAxisRaw("Horizontal");

            animator.SetFloat("Speed", Mathf.Abs(horizontal));

            Vector2 position = transform.position;
            
            position.x = position.x + 3.0f * horizontal * Time.deltaTime;
            transform.position = position;

            //rigidbody2d.MovePosition(position);
        }
    }
}

