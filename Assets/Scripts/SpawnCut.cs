using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class SpawnCut : MonoBehaviour
{

    public GameObject log;
    public GameObject cut;
    public int cutsRequired = 3;
    private int cuts = 0;

    PlayableDirector Director;
    public TimelineAsset LogSpawn;
    public TimelineAsset LogCut;

    private BoxCollider logCollider;
    // Start is called before the first frame update
    void Start()
    {
        Director = gameObject.GetComponent<PlayableDirector>();
        logCollider = log.GetComponent<BoxCollider>();
        spawnCut();
    }

    public void inceaseCuts()
    {
        cuts++;
        Director.playableAsset = LogCut;
        Director.Play();

        if (cuts > cutsRequired)
        { 
            GameManager.instance.backToGame();
            ScoreManager.instance.UpdateScore(10);
            cuts = 0;
        }

    }
    public void spawnCut()
    {
        var randomPosX = Random.Range(logCollider.bounds.min.x, logCollider.bounds.max.x);
        var position = new Vector3(randomPosX, transform.position.y, transform.position.z);
        Instantiate(cut, position, transform.rotation, transform.parent);
    }


}
