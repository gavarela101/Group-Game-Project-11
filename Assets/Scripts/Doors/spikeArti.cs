using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Jayden Saelee Chao
 * Contols spike artifact specific doors
 * 5/13/2025
 */

public class spikeArti : MonoBehaviour
{
    public int locks = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int keyCount = collision.gameObject.GetComponent<PlayerController>().spikeArts;

            if (keyCount >= locks)
            {
                collision.gameObject.GetComponent<PlayerController>().spikeArts -= locks;

                gameObject.SetActive(false);
            }
        }
    }
}
