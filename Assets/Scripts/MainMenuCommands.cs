using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCommands : MonoBehaviour
{
    public AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        audioManager.Play("Menu_music");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        } else if (Input.GetKey(KeyCode.C))
        {
            SceneManager.LoadScene(6);
        }else if (Input.GetKey(KeyCode.Q)) {
            Application.Quit();
        }
            
    }
}
