using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    private int score = 0;
    public UnityEngine.UI.Text scoreText;

    private void Start()
    {
        Time.timeScale = 1;
        if (gameOverCanvas != null) gameOverCanvas.SetActive(false);
    }

    public void AddScore()
    {
        score++;
        if (scoreText != null) scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        if (gameOverCanvas != null) gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
