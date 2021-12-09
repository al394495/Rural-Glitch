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
        if (VariablesGlobales.dia == 3)
        {
            timer += Time.deltaTime;
            if(timer >= 1.0f)
            {
                rand = Random.Range(-8.0f, 27.5f);
                spawnPos.transform.position = new Vector3(rand, 4.5f, 0);
                Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
                timer = 0.0f;
            }
        }
        
    }

    
}
