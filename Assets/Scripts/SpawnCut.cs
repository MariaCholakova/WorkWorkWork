using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCut : MonoBehaviour
{

    public GameObject log;
    public GameObject cut;

    private BoxCollider logCollider;
    // Start is called before the first frame update
    void Start()
    {
        logCollider = log.GetComponent<BoxCollider>();
        spawnCut();
    }

    public void spawnCut()
    {
        var randomPosX = Random.Range(logCollider.bounds.min.x, logCollider.bounds.max.x);
        var position = new Vector3(randomPosX, transform.position.y, transform.position.z);
        Instantiate(cut, position, transform.rotation, transform.parent);
    }
}
