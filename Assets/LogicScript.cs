using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource gameOverMusic;
    public AudioSource gameMusic;


    void Start()
    {
        gameMusic.Play();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        Debug.Log("Adding +" + scoreToAdd + " score");
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        Debug.Log("Restart Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void gameOver()
    {
        if (!gameOverScreen.activeSelf)
        {
            gameMusic.Stop();
            gameOverScreen.SetActive(true);
            gameOverMusic.Play();
        }

    }
}
