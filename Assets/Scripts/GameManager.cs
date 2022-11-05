using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool miniGameCompleted = false;
    //public GameObject gameOverPanel;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    private void GameOver()
    {
        //gameOverPanel.SetActive(true);
    }

    public void Play()
    {
        //SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        //SceneManager.LoadScene("StartMenu");
    }
}

