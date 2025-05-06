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
    public Transform Player;
    public float speed;
    public int damage = 15;

    void Update()
    {
        transform.LookAt(Player);

        float distance = Vector3.Distance(Player.position, transform.position);

        transform.position = Vector3.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
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
