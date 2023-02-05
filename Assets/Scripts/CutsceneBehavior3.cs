using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneBehavior3 : MonoBehaviour
{
    public AudioManager audioManager;

    void Start()
    {
        audioManager.Play("Cutscene_music");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(4);
        }
    }
}
