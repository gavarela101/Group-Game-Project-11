using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Jayden Saelee Chao
 * Contols weapons and shooting
 * 5/10/2025
 */

public class Weapon : MonoBehaviour
{
    public GameObject bulletPre;
    public Transform bulletSpawn;
    public float bulleteloity = 45;
    public float bulletPreLifeTime = 3f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireWeapon();
        }
    }
    private void FireWeapon()
    {
        GameObject bullet = Instantiate(bulletPre, bulletSpawn.position, Quaternion.identity);

        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward.normalized * bulleteloity, ForceMode.Impulse);

        StartCoroutine(Destroybullet(bullet, bulletPreLifeTime));
    }

    private IEnumerator Destroybullet(GameObject bullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(bullet);
    }
}
