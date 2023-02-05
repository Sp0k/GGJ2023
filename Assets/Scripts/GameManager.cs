using TMPro;
using UnityEditor.PackageManager;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI highestLevelText;
    public TextMeshProUGUI scoreText;

    public static int score { get; private set; }
    public static int highScore { get; private set; }
    public static int highestLevel { get; private set; }

    public static void Save()
    {
        SaveManager.Save(new SaveObject(highScore));
    }

    public static void UpdateHighScore(int newHighScore)
    {
        highScore = newHighScore;

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.highScoreText.text = "HighScore: " + highScore.ToString();
    }

    public static void UpdateHighestLevel(int newLevel)
    {
        highestLevel = newLevel;

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.highestLevelText.text = "Highest Level: " + highestLevel.ToString();
    }

    public static void IncrementScore() 
    { 
        score++;

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.scoreText.text = "Score: " + score.ToString();
    }
}
