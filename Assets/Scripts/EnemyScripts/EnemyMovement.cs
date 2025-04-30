using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * gabriel varela 
 * 4/29/25
 * Contains the code on enemy movement
*/

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public int damage = 15;

    void Update()
    {
        // Calculate the direction from the enemy to the player
        Vector3 direction = Player.transform.position - transform.position;

        // Normalize the direction vector to get a unit vector (length 1)
        direction.Normalize();

        // Move the enemy towards the player
        transform.Translate(direction * speed * Time.deltaTime);
    }

    /*
    //deals damage to player on collision 
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            if (other.GetComponent<Player>().health >= 0)
            {
                other.GetComponent<Player>().health -= damage;
            }
        }
    }
    */
}
