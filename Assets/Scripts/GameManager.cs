using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public GameObject gameOverPanel;
    public GameObject gameWinPanel;
    
    public GameObject mainCamera;
    public GameObject eggGame;
    public GameObject logGame;
    public GameObject cowGame;
    private GameObject objToDestroy;

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

    public void backToGame() 
    {
        eggGame.SetActive(false);
        logGame.SetActive(false);
        cowGame.SetActive(false);
        mainCamera.SetActive(true);
        Destroy(objToDestroy);
    }

    public void playGame(GameObject game, GameObject toDestroy) 
    {
        game.SetActive(true);
        mainCamera.SetActive(false);
        objToDestroy = toDestroy;
    }

}

