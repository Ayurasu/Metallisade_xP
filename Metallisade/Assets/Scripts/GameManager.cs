using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SpawnTarget());
        score = 0;
        scoreText.text = "pisteet" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
