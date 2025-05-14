using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Jayden Saelee Chao
 * Contols orange artifact specific doors
 * 5/13/2025
 */

public class orangeArti : MonoBehaviour
{
    public int locks = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int keyCount = collision.gameObject.GetComponent<PlayerController>().orangeArts;

            if (keyCount >= locks)
            {
                collision.gameObject.GetComponent<PlayerController>().orangeArts -= locks;

                gameObject.SetActive(false);
            }
        }
    }
}
