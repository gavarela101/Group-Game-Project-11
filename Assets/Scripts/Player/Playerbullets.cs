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
    public int damage; 

    //when the bullet collids with enemy subtract enemy health
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<test>())
        {
            //if the enemy current hp is more than 0
            if (other.GetComponent<test>().currentHealth >= 0)
            {
                //subtracts enemy health
                other.GetComponent<test>().currentHealth -= damage;
            }
        }
        Destroy(gameObject);
    }
}
