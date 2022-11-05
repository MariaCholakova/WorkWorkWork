using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private int catchesCount = 0;
    public EggsGameSO settings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        // Get the horizontal axis. By default it is mapped to the arrow keys.
        // The value is -1 for left, 0 for neutral or 1 for right.
        float horizontal = Input.GetAxis("Horizontal");

        // Move the paddle either left or right depending on horizontal.
        // Multiply by deltaTime for moving 1 unit per second not per frame.
        this.transform.Translate(Vector2.right * horizontal * Time.deltaTime * settings.BasketSpeed);

        if (this.transform.position.x < settings.LeftScreenEdge)
        {
            this.transform.position = new Vector2(settings.LeftScreenEdge, this.transform.position.y);
        }
        if (this.transform.position.x > settings.RightScreenEdge)
        {
            this.transform.position = new Vector2(settings.RightScreenEdge, this.transform.position.y);
        }
    }

    private void OnTriggerEnter(Collider egg)
    {
        Destroy(egg.gameObject);
        catchesCount++;
        if (catchesCount > 5)
        {
            GameManager.instance.miniGameCompleted = true;
            ScoreManager.instance.UpdateScore(10);
        }
    }


}
