using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public float speed = 1.0f;
    public float xRange = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //limits the players movement
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Moves the player from side to side
        float horizontalInput = Input.GetAxis("Horizontal");
        //Debug.Log("kgmklgmklfgmdklg");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);



    }
    
}
