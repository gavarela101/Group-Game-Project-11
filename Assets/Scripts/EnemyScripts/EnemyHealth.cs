using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Health;

    //Subtracts enemy health when shot by player
    public void LoseHealth()
    {
        //have Enemy lose health 
        Health--;

        //check if Enemy has zero health 
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
