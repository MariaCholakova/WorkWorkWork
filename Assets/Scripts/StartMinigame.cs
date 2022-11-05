using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMinigame : MonoBehaviour
{
    public GameObject minigame;
    public GameObject toDestroy;

    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.playGame(minigame, toDestroy);
    }
}
