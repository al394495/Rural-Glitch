using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArdillaController : MonoBehaviour
{
    public float speed;
    public bool vertical;
    public float changeTime = 7.0f;
    public Animator animator;

    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }

        if (VariablesGlobales.minijuegoRealizado3)
        {
            animator.SetBool("Glitched", true);
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction; 
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction; 
            animator.SetFloat("MoveX", direction);
            animator.SetFloat("MoveY", 0);
        }

        rigidbody2D.MovePosition(position);
    }
}
