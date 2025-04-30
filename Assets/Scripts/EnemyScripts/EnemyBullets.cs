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

    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            if (other.GetComponent<Player>().health >= 0)
            {
                other.GetComponent<Player>().health -= damage;
            }
        }
    }
    */
}
