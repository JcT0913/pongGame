using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float speed = 3;
    // using variable direction to stand for the direction where ball will go
    // 0 -> to left
    // 1 -> to right
    private int direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        float x = Random.Range(-10f, -5f);
        float y = Random.Range(-5f, 5f);
        Vector3 force = new Vector3(0, 0, 0);

        if (direction == 0)
        {
            direction = 1;
            force = new Vector3(x, y, 0);
        }
        else if (direction == 1)
        {
            direction = 0;
            //x = x * -1;
            force = new Vector3(-x, y, 0);
        }

        //Vector3 force = new Vector3(x, y, 0);

        rigidbody.velocity = new Vector3(0, 0, 0);
        rigidbody.AddForce(force.normalized * speed);
    }
}
