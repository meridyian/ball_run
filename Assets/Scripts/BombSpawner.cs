using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject bombPrefab;

    void Start()
    {
        SpawnBombs();
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