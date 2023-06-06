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
    public bool isGameActive;
    public static int Sc0re;
    

    //public AudioSource collectSound;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnRandomAsset();
        UpdateScore(0);
        InvokeRepeating("SpawnRandomAsset", startDelay, spawnInterval);
        isGameActive = true;
        
       
        
    }

    

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


        Debug.Log("Banana 2");
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        return;


    }

   
    
}
