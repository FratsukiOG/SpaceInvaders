using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float spawnDelay = 1f;
    public float spawnAreaWidth = 10f;
    public float spawnAreaHeight = 5f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnInterval);
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnAreaWidth / 2f, spawnAreaWidth / 2f), spawnAreaHeight, 0f);
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
