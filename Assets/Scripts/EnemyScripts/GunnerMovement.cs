using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Gabriel Varela 
 * 4/30/25
 * Handles the movements of all enemies with projectile weapons
*/

public class GunnerMovement : MonoBehaviour
{
    public Transform Player;
    public float desiredDistance;
    public float speed;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.position);

        if (distance < desiredDistance)
        {
            // Move the enemy away from the player
            Vector3 direction = (Player.position - transform.position).normalized;
            transform.Translate(-direction * speed * Time.deltaTime);
        }
        else
        {
            // Move the enemy towards the player
            Vector3 direction = (Player.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
