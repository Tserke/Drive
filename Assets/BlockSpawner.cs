using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    public float waveTime = 1f;
    private float spawnTime = 2f;
   
    void Update()
    {
        if (Time.time >= spawnTime)
        { 
            SpawnBlocks();
            spawnTime = Time.time + waveTime;
        }
    }
    
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                //Quaternion.Identity is used when rotate is not needed
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }

}
