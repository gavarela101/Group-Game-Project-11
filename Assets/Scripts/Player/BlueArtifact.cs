using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Jayden Saelee Chao
 * Contols blue artifact rotation and collection
 * 4/28/2025
 */

public class BlueArtifact : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, 1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            other.GetComponent<PlayerController>().blueArts++;

            Destroy(gameObject);
        }
    }
}
