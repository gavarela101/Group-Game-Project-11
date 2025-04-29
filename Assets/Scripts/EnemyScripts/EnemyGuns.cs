using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * gabriel varela 
 * 4/29/25
 * Contains the code on enemy guns attack and health
*/

public class Gunner : MonoBehaviour
{
    public float attackDelay = 2f;
    public float attackRate = 1f;
    public float gunHealth;
    
    public GameObject bullet;

    void Start()
    {
        InvokeRepeating("Attack", attackDelay, attackRate);
    }

    void Attack()
    {
        //Code to shoot projectile
    }

    private void OnDestroy()
    {
        //Code to destroy enemy guns after gun health is depleted
    }
}
