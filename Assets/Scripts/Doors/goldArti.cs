using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Jayden Saelee Chao
 * Contols gold artifact specific doors
 * 5/13/2025
 */

public class goldArti : MonoBehaviour
{
    public int locks = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            int keyCount = collision.gameObject.GetComponent<PlayerController>().goldArts;
             
            if (keyCount >= locks)
            { 
                collision.gameObject.GetComponent<PlayerController>().goldArts -= locks;
                 
                gameObject.SetActive(false);
            }
        }
    }
}
