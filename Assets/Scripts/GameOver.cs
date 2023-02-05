using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(0);  
        }
    }
}
