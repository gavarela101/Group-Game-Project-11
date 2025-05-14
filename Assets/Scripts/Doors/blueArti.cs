using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Jayden Saelee Chao
 * Contols blue artifact specific doors
 * 5/13/2025
 */

public class blueArti : MonoBehaviour
{
    public int locks = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int keyCount = collision.gameObject.GetComponent<PlayerController>().blueArts;

            if (keyCount >= locks)
            {
                collision.gameObject.GetComponent<PlayerController>().blueArts -= locks;

                gameObject.SetActive(false);
            }
        }
    }
}
