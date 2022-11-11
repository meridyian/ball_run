using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public float bombingInterval = 0.75f;
    
    [SerializeField] GameObject bombPrefab;

    public Transform[] spawnPoints;

    public float next_bombing = 0f;

    void Update()
    {
        if (next_bombing <= Time.time)
        {
            SpawnBomb();
            next_bombing = Time.time + bombingInterval;
        }
    }

    void SpawnBomb()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(bombPrefab, spawnPoint.position, spawnPoint.rotation);
    }




}