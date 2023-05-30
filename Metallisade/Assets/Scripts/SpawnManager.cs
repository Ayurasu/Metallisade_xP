using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] flyingPrefabs;
    private float spawnRangeX = 1.5f;
    private float spawnPosZ = -1;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAsset", startDelay, spawnInterval);
    }

    // Update is called once per frameasse
    void Update()
    {
        
    }

    void SpawnRandomAsset()
    {
        int assetIndex = Random.Range(0, flyingPrefabs.Length);
        //Randomize the location
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 4, spawnPosZ);

        //Spawns the assets

        Instantiate(flyingPrefabs[assetIndex], spawnPos, flyingPrefabs[assetIndex].transform.rotation);
    }
   

}
