using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private float sleepTime = 5;
    [SerializeField] private Transform[] spawnsPoints;
    
    void Start()
    {
        InvokeRepeating("SpawnEnemy",sleepTime, spawnRate );
    }

    private void SpawnEnemy()
    {
        Vector3 pos = spawnsPoints[Random.Range(0, spawnsPoints.Length)].position;
        Instantiate(enemyPrefab, pos, Quaternion.identity);
    }
}
