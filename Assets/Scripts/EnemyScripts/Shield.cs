using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * gabriel varela 
 * 5/6/25
 * Contains the code on enemies' shield
*/

public class NewBehaviourScript : MonoBehaviour
{
    public int maxHealth = 20;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Destroy();
        }
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
