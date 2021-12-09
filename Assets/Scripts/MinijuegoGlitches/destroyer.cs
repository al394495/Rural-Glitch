using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "destroyer")
        {
            destruction();
        }

    }

    void destruction()
    {
        Destroy(this.gameObject);
    }
}
