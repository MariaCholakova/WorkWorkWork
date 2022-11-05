using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public GameObject GameOverPrefab;
    private const float TIME_TO_PLAY = 45f; // 180 seconds
    private float timeLeft = 0f;
    public TMP_Text timeLeftText;
    private int score = 0;
    public TMP_Text scoreText;

    private float elapsedTime = 0f;

    void Awake()
    {
        instance = this;
        GameOverPrefab.SetActive(false);

    }

    string FormatTime(float timeInSeconds)
    {
        return Mathf.Floor(timeInSeconds / 60) + ":" + timeInSeconds % 60;
    }
      

    // Start is called before the first frame update
    void Start()
    {
        timeLeftText.text = "TIME LEFT: " + FormatTime(TIME_TO_PLAY);
        scoreText.text = "SCORE: " + score.ToString();
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        timeLeft = TIME_TO_PLAY - elapsedTime;
        timeLeftText.text = "TIME LEFT: " + FormatTime(Mathf.Floor(timeLeft));

        GameOverPrefab.SetActive(timeLeft < 0);
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "SCORE: " + score.ToString();
    }
}
