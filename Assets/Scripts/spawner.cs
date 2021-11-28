using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    public float timer;
    public float rand;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2.0f)
        {
            rand = Random.Range(-8.0f, -1.0f);
            spawnPos.transform.position = new Vector3(rand, 2, 0);
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
            timer = 0.0f;
        }
    }

    
}
