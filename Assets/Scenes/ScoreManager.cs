using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
   

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject gameOverPanelObject;

    private int score = 0;

    void Start()
    {
        Time.timeScale = 1;
        if (gameOverPanelObject != null) gameOverPanelObject.SetActive(false);
        UpdateHighScoreDisplay();
    }

    public void AddScore(int amount)
    {
        score += amount;
        if (scoreText != null) scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        if (gameOverPanelObject != null)
        {
            gameOverPanelObject.SetActive(true);
            Time.timeScale = 0;
            CheckHighScore();
        }
    }

    void CheckHighScore()
    {
        int savedHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (score > savedHighScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        UpdateHighScoreDisplay();
    }

    void UpdateHighScoreDisplay()
    {
        if (highScoreText != null)
        {
            highScoreText.text = "Best: " + PlayerPrefs.GetInt("HighScore", 0);
        }
    }

    public void RestartGame()
    {
        PersistentAudioManager.PlaySound();
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        PersistentAudioManager.PlaySound();
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu"); 
    }

    public void ExitGame()
    {
        PersistentAudioManager.PlaySound();
        Debug.Log("O'yindan chiqilmoqda...");
        Application.Quit();
    }
}