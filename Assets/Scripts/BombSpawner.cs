using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public float bombingInterval = 0.75f;
    
    [SerializeField] GameObject bombPrefab;

    public Transform[] spawnPoints;

    //public float next_bombing = 0f;

    private void Start()
    {
        StartCoroutine(Bomb());
    }



    void SpawnBomb()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(bombPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    IEnumerator Bomb()
    {
        while(true)
        {
            SpawnBomb();
            yield return new WaitForSeconds(bombingInterval);
            //next_bombing = next_bombing + bombingInterval;
        }
    }

    




}