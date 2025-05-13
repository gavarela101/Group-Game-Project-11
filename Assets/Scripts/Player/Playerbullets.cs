using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Gabriel Varela
 * 5/9/25
 * handles code for player bullets colliding with enemies 
*/

public class Playerbullets : MonoBehaviour
{
    public int damage = 5; 

    //when the bullet collids with enemy subtract enemy health
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //if the enemy current hp is more than 0
            if (collision.gameObject.GetComponent<test>().currentHealth >= 0)
            {
                //subtracts enemy health
                collision.gameObject.GetComponent<test>().currentHealth -= damage;
            }
        }
        Destroy(gameObject);
    }
}
