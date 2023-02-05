using TMPro;
using UnityEditor.PackageManager;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score { get; private set; }

    public TextMeshProUGUI scoreText;

    private void Start()
    {
        score = 0;
    }

    public static void IncrementScore() 
    { 
        score++;
        
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.scoreText.text = "Score: " + score.ToString();
    }
}
