using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * gabriel varela 
 * 4/29/25
 * Contains the code on enemy movement and helath
*/

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public float health;

    void Update()
    {
        // Calculate the direction from the enemy to the player
        Vector3 direction = Player.transform.position - transform.position;

        // Normalize the direction vector to get a unit vector (length 1)
        direction.Normalize();

        // Move the enemy towards the player
        transform.Translate(direction * speed * Time.deltaTime);
    }

    //Code to make enemy dissapear once health is <= 0
}
