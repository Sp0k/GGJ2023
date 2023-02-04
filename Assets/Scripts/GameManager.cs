using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    public static int highScore { get; private set; }

    public static void Save()
    {
        SaveManager.Save(new SaveObject(highScore));
    }

    public static void UpdateScore(int newHighScore)
    {
        highScore = newHighScore;

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.highScoreText.text = highScore.ToString();
    }
}
