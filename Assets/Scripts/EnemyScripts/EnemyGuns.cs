using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * gabriel varela 
 * 5/6/25
 * Contains the code on enemy guns attack
*/

public class Gunner : MonoBehaviour
{
    public Transform Player;
    public Rigidbody projectile;

    public float attackDelay = 2f;
    public float attackRate = 1f;
    public float range = 30;
    public float bulletImpulse = 20.0f;
    public float gunHealth;

    private bool inRange = false;

    void Start()
    {
        float rand = Random.Range(1.0f, 2.0f);
        InvokeRepeating("Shoot", 2, rand);
    }

    void Update()
    {
        inRange = Vector3.Distance(transform.position, Player.position) < range;
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Shoot()
    {
        if (inRange)
        {
            Rigidbody bullet = (Rigidbody)Instantiate(projectile, transform.position + transform.forward, transform.rotation);
            bullet.AddForce(transform.forward * bulletImpulse, ForceMode.Impulse);
        }
    }
}
