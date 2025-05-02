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
    public GameObject[] EnemyPrefabs;
    
    public float spawnInterval;
    public Vector3 spawnAreaSize;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    /// <summary>
    /// spawns enemy in a random location after a certain amount of time
    /// </summary>
    /// <returns></returns>
    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            //selects a random enemy to spawn
            int prefabIndex = Random.Range(0, EnemyPrefabs.Length);
            GameObject enemyPrefab = EnemyPrefabs[prefabIndex];

            //creates a random spawn location for enemies
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnAreaSize.x, spawnAreaSize.x), 
                0,//keeps y at zero
                Random.Range(-spawnAreaSize.z, spawnAreaSize.z));

            //Instantiate enemies
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            //Spawn cooldown
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
