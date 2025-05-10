using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

/*
 * Gabriel Varela
 * 5/6/25
 * handles code for enemy movment using Ai navigation
*/

public class test : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent nav;
    public float stopDistance;
    public float followDistance;

    public int damage = 5;
    // Time between damage
    public float damageInterval = 1.0f; 
    //time since last damage taken
    private float lastDamageTime; 

    public int maxHealth;
    public int currentHealth;

    private void Start()
    {
        //sets Player transform using the Player tag
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        //sets nav
        nav = GetComponent<NavMeshAgent>();
        //sets current health at the start of game
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Player == null) return;  // Stop if player is null

        //calculates distance to the player 
        float distanceToPlayer = Vector3.Distance(transform.position, Player.transform.position);

        if (distanceToPlayer <= followDistance && distanceToPlayer >= stopDistance)
        {
            // Follow the player within the follow distance
            nav.SetDestination(Player.transform.position);
            nav.isStopped = false;
        }
        else if (distanceToPlayer < stopDistance)
        {
            // Stop at the stop distance
            nav.SetDestination(transform.position); // Keep agent at current position
            nav.isStopped = true;
        }
        else
        {
            // Stop chasing if player is too far
            nav.SetDestination(transform.position); // Keep agent at current position
            nav.isStopped = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && Time.time - lastDamageTime >= damageInterval)
        {
            if (other.gameObject.GetComponent<PlayerController>().health >= 0)
            {
                other.gameObject.GetComponent<PlayerController>().health -= damage;
                lastDamageTime = Time.time;
            }
        }
    }

    public void Die()
    {
        currentHealth--;

        if (currentHealth <= maxHealth)
        {
            //destroys game object
            Destroy(gameObject);
        }
    }
}
