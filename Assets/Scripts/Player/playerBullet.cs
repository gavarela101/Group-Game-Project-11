using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Jayden Saelee Chao
 * Contols bullets
 * 5/10/2025
 */

public class playerBullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            print("hit" + collision.gameObject.name + "!");
            Destroy(gameObject);
        }
    }
}
