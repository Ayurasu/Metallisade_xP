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
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;

    //public AudioSource collectSound;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnRandomAsset();
        UpdateScore(0);
        InvokeRepeating("SpawnRandomAsset", startDelay, spawnInterval);

       
        isGameActive = true;
    }

    

    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        Debug.Log(score);
        scoreText.text = "Pisteet " + score;

        if (gameObject.CompareTag("Banana"))
        {
            Debug.Log("game over");
            GameOver();
            Destroy(gameObject);
            return;
        }
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

            //Debug.Log("Toimiik t‰‰?");
            //Spawns the assets

            Instantiate(flyingPrefabs[assetIndex], spawnPos, flyingPrefabs[assetIndex].transform.rotation);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("tiidada");
        
    }



    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene(true).name);
    }
    
}
