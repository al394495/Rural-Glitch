using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManagerMenu : MonoBehaviour
{
    private static MusicManagerMenu musicManagerInstance;
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        if (MainMenuScript.play == true)
        {
            Destroy(gameObject);
        }
    }
}
