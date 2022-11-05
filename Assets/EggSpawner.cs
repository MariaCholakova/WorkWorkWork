using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject fallingEggPrefab;
    public EggsGameSO settings;
    private double elapsedTime = 0;


    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > settings.FallingInterval)
        {
            elapsedTime = 0;
            Vector3 position = new Vector3(Random.Range(settings.LeftScreenEdge + 2, settings.RightScreenEdge - 2), this.transform.position.y, this.transform.position.z);
            Instantiate(fallingEggPrefab, position, Quaternion.identity);
        }
    }
}
