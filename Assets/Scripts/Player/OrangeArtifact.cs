using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Jayden Saelee Chao
 * Contols orange artifact rotation and collection
 * 4/29/2025
 */

public class OrangeArtifact : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0, 1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            other.GetComponent<PlayerController>().orangeArts++;

            Destroy(gameObject);
        }
    }
}
