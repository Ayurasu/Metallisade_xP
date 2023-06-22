using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] flyingPrefabs;
    private float spawnRangeX = 1.5f;
    private float spawnPosZ = -1;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI replayScore;
    public bool isGameActive;
    private float spawnRate = 1.0f;
    public static int difficulty = 1;
    

    //public AudioSource collectSound;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnRandomAsset();
        StartGame();
        DontDestroyOnLoad(this.gameObject);
    }

    public void StartGame()
    {
        spawnRate /= GameManager.difficulty;
        Debug.Log("Starting game diff: " + GameManager.difficulty);
        UpdateScore(0);
        InvokeRepeating("SpawnRandomAsset", startDelay, spawnRate);
        isGameActive = true;

    }

    public void setDifficulty(int difficulty) {
        GameManager.difficulty = difficulty;
    }

    
    //Updates the scoreUI
    public void UpdateScore(int scoreToAdd) 
    {
        if (scoreToAdd < -1)
        {
            GameOver();
            return;
        }

        score += scoreToAdd;
        //Debug.Log(score);
        scoreText.text = "Pisteet " + score;

       
    }

  
  



    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAsset()
    {
        
        
        if (isGameActive)
        {
            int assetIndex = Random.Range(0, flyingPrefabs.Length);
            //Randomize the location
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 4, spawnPosZ);

            //Debug.Log("Toimiik tää?");
            //Spawns the assets

            Instantiate(flyingPrefabs[assetIndex], spawnPos, flyingPrefabs[assetIndex].transform.rotation);
        }
    }


  

    public void GameOver()
    {


        Debug.Log("GameOver");
        Debug.Log(IsInvoking("SpawnRandomAsset"));
        CancelInvoke();
        Debug.Log(IsInvoking("SpawnRandomAsset"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        isGameActive = false;
        return;


    }

   
    
}
