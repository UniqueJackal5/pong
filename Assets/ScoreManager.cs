using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;

    private int player1Score = 0;
    private int player2Score = 0;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void Player1Scored()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
    }

    public void ResetScores()
    {
        player1Score = 0;
        player2Score = 0;
        player1ScoreText.text = "0";
        player2ScoreText.text = "0";
    }
}
