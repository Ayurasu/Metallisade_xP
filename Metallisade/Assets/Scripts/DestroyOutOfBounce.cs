using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounce : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }
      else if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
