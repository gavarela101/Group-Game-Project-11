using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * gabriel varela 
 * 4/29/25
 * Contains the code on enemies' shield
*/

public class NewBehaviourScript : MonoBehaviour
{

    public int Health;

    //Subtracts shield health when shot by player
    public void takeDamage()
    {
        //have shield lose health 
        Health--;

        //check if shield has zero health 
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
