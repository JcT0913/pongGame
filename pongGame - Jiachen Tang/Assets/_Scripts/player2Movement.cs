using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Movement : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this player should only be able to move in the right half of space
        // using if-else to avoid A & D (or W & S) are pressed at the same time
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > 0.25f)
        {
            transform.Translate(new Vector3(-0.25f * speed, 0, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 8.15f)
        {
            transform.Translate(new Vector3(0.25f * speed, 0, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 3.95f)
        {
            transform.Translate(new Vector3(0, 0.25f * speed, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -3.95f)
        {
            transform.Translate(new Vector3(0, -0.25f * speed, 0));
        }
    }
}
