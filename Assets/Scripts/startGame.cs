using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public bool isStart;
    public bool isCredits;
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
      
    }
    public void OnClick() {
        if(isStart) {
            SceneManager.LoadScene(1);
           
        }
         Debug.Log("ur mom");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
