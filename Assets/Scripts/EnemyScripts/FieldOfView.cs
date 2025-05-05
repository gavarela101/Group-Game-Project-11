using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Jayden Saelee Chao
 * 5/5/2025
 * Controls the Line of Sight for enemies
 */

public class FieldOfView : MonoBehaviour
{
    public float radius;
    [Range(0, 360)]
    public float angle;

    public GameObject PlayerScript;

    public LayerMask targetMask;
    public LayerMask obstructionMask;

    public bool CanSeePlayer;

    private void Start()
    {
        PlayerScript = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(LoSRoutine());
    }

    private IEnumerator LoSRoutine()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            LineofSightCheck();
        }
    }

    private void LineofSightCheck()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);

        if (rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;

            if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);

                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obstructionMask))
                {
                    CanSeePlayer = true;
                }
                else
                {
                    CanSeePlayer = false;
                }
            }
            else
            {
                CanSeePlayer = false;
            }
            
        }
        else if (CanSeePlayer)
        {
            CanSeePlayer = false;
        } 
    }
}
