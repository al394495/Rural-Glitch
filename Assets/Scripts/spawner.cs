using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    public float timer;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2.0f)
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
            timer = 0.0f;
        }
    }
}
