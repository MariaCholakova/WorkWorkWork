using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    public GameObject saw;

    private SawMover sawMover;

    private void Awake()
    {
        sawMover = saw.GetComponent<SawMover>();
    }

    private void OnTriggerEnter(Collider other)
    {
        sawMover.changeDirection();
    }
}
