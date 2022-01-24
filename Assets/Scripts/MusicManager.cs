using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    private static MusicManager musicManagerInstance;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (musicManagerInstance == null)
        {
            musicManagerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menú"))
        {
            Destroy(gameObject);
        }

        if (VariablesGlobales.cinematicaFin == true)
        {
            Destroy(gameObject);
        }
    }
}