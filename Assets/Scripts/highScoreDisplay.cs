using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class highScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text += GameManager.highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
