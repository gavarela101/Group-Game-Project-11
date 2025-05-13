using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * gabriel varela 
 * 4/30/25
 * handles code for the death floor
 */
public class DeathFloor : MonoBehaviour
{
    public int death = 200;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            other.GetComponent<PlayerController>().health -= death;
        }
    }
}