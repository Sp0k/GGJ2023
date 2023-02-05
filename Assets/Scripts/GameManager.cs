using TMPro;
using UnityEditor.PackageManager;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score { get; private set; }

    public TextMeshProUGUI scoreText;
    public AudioManager audioManager;

    private void Start()
    {
        score = 0;
        audioManager.Play("level");
    }

    public static void IncrementScore() 
    { 
        score++;
        
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.scoreText.text = "Score: " + score.ToString();
    }
}
