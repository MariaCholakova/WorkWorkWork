using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutting : MonoBehaviour
{

    public GameObject spawnCutObj;
    private SpawnCut spawnCut;

    void Start()
    {
        spawnCut = spawnCutObj.GetComponent<SpawnCut>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)) 
        {
            spawnCut.spawnCut();
            Destroy(gameObject);
        }
    }
}
