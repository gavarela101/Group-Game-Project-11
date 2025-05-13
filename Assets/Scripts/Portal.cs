using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * gabriel varela
 * 4/20/25
 * handles code for portals 
*/

public class Portal : MonoBehaviour
{
    public Transform portalExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = portalExit.transform.position;
        }
    }
}
