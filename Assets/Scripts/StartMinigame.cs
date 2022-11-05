using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMinigame : MonoBehaviour
{
    public GameObject minigame;
    public GameObject mainCamera;

    private void OnTriggerEnter(Collider other)
    {
        minigame.GetComponentInChildren<Camera>(true).gameObject.SetActive(true);
        mainCamera.SetActive(false);
    }
}
