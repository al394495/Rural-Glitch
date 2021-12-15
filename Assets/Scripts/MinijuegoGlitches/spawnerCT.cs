using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerCT : MonoBehaviour
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
            if (timer >= 0.8f)
            {
                rand = Random.Range(-8.0f, 21.5f);
                spawnPos.transform.position = new Vector3(rand, 3f, 0);
                Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
                timer = 0.0f;
            }
        }

    }
}
