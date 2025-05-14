using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * gabriel varela
 * 4/20/25
 * handles code for portals 
*/

public class Portal : MonoBehaviour
{
    public GameObject playerPrefab; // Assign the player prefab in the inspector
    public Transform respawnPoint; // Assign the respawn point in the inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Destroy the player
            Destroy(other.gameObject);
            // Spawn the player at the respawn point
            Instantiate(playerPrefab, respawnPoint.position, respawnPoint.rotation);
            DestroyAllObjectsWithTag();
        }
    }

    public void DestroyAllObjectsWithTag()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject obj in objectsWithTag)
        {
            Destroy(obj);
        }
    }
}
