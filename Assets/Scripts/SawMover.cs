using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMover : MonoBehaviour
{

    public float speed = 5f;
    private bool isMovingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (isMovingRight)
        {
            moveSawRight();
        }
        else
        {
            moveSawLeft();
        }
        
    }

    public void changeDirection()
    {
        isMovingRight = !isMovingRight;
    }

    private void moveSawRight() 
    {
        transform.Translate(speed * Time.deltaTime , 0, 0);
    }

    private void moveSawLeft()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
