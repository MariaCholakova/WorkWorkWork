using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMinigame : MonoBehaviour
{
    public GameObject minigame;

    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.playGame(minigame);
    }
}
