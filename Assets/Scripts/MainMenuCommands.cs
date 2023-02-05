using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCommands : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(4);
        } else if (Input.GetKey(KeyCode.C))
        {
            SceneManager.LoadScene(3);
        }else if (Input.GetKey(KeyCode.Q)) {
            Application.Quit();
        }
            
    }
}
