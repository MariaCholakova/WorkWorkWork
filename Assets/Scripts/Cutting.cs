using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutting : MonoBehaviour
{

    public GameObject spawnCutObj;
    public int cutsRequired = 3;
    private SpawnCut spawnCut;
    private int currentCuts = 0;

    void Start()
    {
        spawnCut = spawnCutObj.GetComponent<SpawnCut>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)) 
        {
            currentCuts++;
            if (currentCuts >= cutsRequired) 
            {
                
            }
            spawnCut.spawnCut();
            Destroy(gameObject);
        }
    }
}
