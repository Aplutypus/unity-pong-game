using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TextMeshProUGUI win;
    public TextMeshProUGUI scoreP1;
    public TextMeshProUGUI scoreP2;

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void SetGameOverScreen(int scorep1, int scorep2, string player)
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        SetWinText(player);
        SetPlayer1ScoreText(scorep1);
        SetPlayer2ScoreText(scorep2);
    }

    public void SetPlayer1ScoreText(int score)
    {
        scoreP1.SetText(score.ToString());
    }

    public void SetPlayer2ScoreText(int score)
    {
        scoreP2.SetText(score.ToString());
    }

    public void SetWinText(string player)
    {
        win.SetText("Player " + player + " wins!");
    }
}
