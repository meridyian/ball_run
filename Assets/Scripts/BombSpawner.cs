using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public float bombingInterval = 1.5f;
    public float bombing_time = 2f;
    public GameObject bombPrefab;

    void Start()
    {
        if(Time.time >= bombing_time)
        {
            SpawnBombs();
            bombing_time = Time.time + bombingInterval;
        }
        
    }


    void SpawnBombs()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            // do smth for spawnPoints.Length amount of times

            if (randomIndex != i)
            {
                Instantiate(bombPrefab, spawnPoints[i].position, Quaternion.identity);
                
            }

        }
    }

}