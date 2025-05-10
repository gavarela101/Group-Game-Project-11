using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
    public int damage;

    // Update is called once per frame
    void Update()
    {
        //destroys laser after set seconds
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>())
        {
            if (other.GetComponent<PlayerController>().health >= 0)
            {
                other.GetComponent<PlayerController>().health -= damage;
            }
        }
    }
}
