using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    //Player moves twice and jumittaa
    public GameObject Player;
    public float xRange = 1.0f;
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            if (endTouchPosition.x > startTouchPosition.x)
            {

                Left();

            }
            if (endTouchPosition.x < startTouchPosition.x)
            {
                
                Right();
                
            }
            
        }
    }
    private void Left()
    {
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            Debug.Log("To left");
        }
        Player.transform.position = new Vector3(Player.transform.position.x + 1, Player.transform.position.y, Player.transform.position.z);
    }

    private void Right()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            Debug.Log("To right");
        }
        Player.transform.position = new Vector3(Player.transform.position.x - 1, Player.transform.position.y, Player.transform.position.z);

    }

}
