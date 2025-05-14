using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * gabriel varela
 * 4/28/25
 * handles the spawning for base enemies and base enemy variants
*/

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Array of enemy prefabs to choose from
    public Transform[] spawnPoints; // Array of spawn points to choose from
    public float spawnInterval; // Time between each spawn
    public int maxEnemies = 10; // Maximum number of enemies to spawn

    // Keep track of spawned enemies
    private int _currentEnemyCount = 0;

    private void Start()
    {
        // Start the spawning coroutine
        StartCoroutine(SpawnEnemies()); 
    }

    // Spawn enemies using a coroutine
    IEnumerator SpawnEnemies()
    {
        // Limit the number of enemies spawned
        while (_currentEnemyCount < maxEnemies) 
        {
            // Randomly select a prefab and spawn point
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);

            // Instantiate the enemy prefab at the spawn point
            GameObject newEnemy = Instantiate(enemyPrefabs[enemyIndex], spawnPoints[spawnPointIndex].position, Quaternion.identity);
            _currentEnemyCount++;

            // Wait for the specified interval before spawning the next enemy
            yield return new WaitForSeconds(spawnInterval);
        }

        Debug.Log("Maximum number of enemies reached, stopping spawning.");
        yield break; // Stop the coroutine
    }

}
