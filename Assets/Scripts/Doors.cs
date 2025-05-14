using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Xabiel Garcia
 * Controls artifacts that open doors
 * 05/13/2025
 */


public class Doors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>.blueArts>=1)
        {
            SetActive(false);
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
