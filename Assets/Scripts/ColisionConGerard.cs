using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionConGerard : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        Time.timeScale = 0.0f;
    }
}
