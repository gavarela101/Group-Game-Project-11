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

    void Update()
    {
        transform.LookAt(Player);

        float distance = Vector3.Distance(Player.position, transform.position);

        if (distance < desiredDistance)
        {
            Vector3 currentPosition = transform.position;
        }
        else
        {
            // Move the enemy towards the player
            transform.position = Vector3.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        }
    }
}
