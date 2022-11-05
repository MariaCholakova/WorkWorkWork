using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Text highScoreText;
    [SerializeField]
    private GameObject instructionsWindow;
    [SerializeField]
    private GameObject leaderboardWindow;

    private void Start()
    {
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ShowInstructions()
    {
        instructionsWindow.SetActive(true);
    }

    public void HideInstructions()
    {
        instructionsWindow.SetActive(false);
    }

    public void ShowLeaderboard()
    {
        leaderboardWindow.SetActive(true);
    }

    public void QuitLeaderboard()
    {
        leaderboardWindow.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

