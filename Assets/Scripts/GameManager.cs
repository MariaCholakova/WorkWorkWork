using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private const double TIME_TO_PLAY = 180; // 180 seconds
    private double timeSpent = 0;
    public Text timeSpentText;
    private int score = 0;
    public Text scoreText;
    public Text highScoreText;
    
    public GameObject gameOverPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        timeSpentText.text = "TIME: " + timeSpent;
        scoreText.text = "SCORE: " + score;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "SCORE: " + score;
    }

    private void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        SceneManager.LoadScene("StartMenu");
    }
}

