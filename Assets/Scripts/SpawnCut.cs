using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCut : MonoBehaviour
{

    public GameObject log;
    public GameObject cut;
    public GameObject destroyedTrees;
    public int cutsRequired = 3;
    private int cuts = 0;

    private BoxCollider logCollider;
    // Start is called before the first frame update
    void Start()
    {
        logCollider = log.GetComponent<BoxCollider>();
        spawnCut();
    }

    public void inceaseCuts()
    {
        cuts++;
        if (cuts >= cutsRequired)
        {
            Destroy(destroyedTrees);
            GameManager.instance.backToGame();
            GameManager.instance.UpdateScore(10);
        }

    }
    public void spawnCut()
    {
        var randomPosX = Random.Range(logCollider.bounds.min.x, logCollider.bounds.max.x);
        var position = new Vector3(randomPosX, transform.position.y, transform.position.z);
        Instantiate(cut, position, transform.rotation, transform.parent);
    }
}
