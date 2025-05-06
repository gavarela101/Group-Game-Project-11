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


    private void Start()
    {
        //sets Player transform using the Player tag
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        //sets nav
        nav = GetComponent<NavMeshAgent>();
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
}
