using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            collision.gameObject.transform.position = new Vector3(0, 0, 0);
            collision.gameObject.GetComponent<ballMovement>().StartGame();
        }
    }
}
