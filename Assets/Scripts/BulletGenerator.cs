using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject munition;
    public float shootDelay = 2f;
    public bool canShoot = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Scale();
        }
        if (canShoot)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        canShoot = false;
        Instantiate(munition, transform.position, transform.rotation);
        Invoke("CanShoot", shootDelay);
    }

    private void CanShoot()
    {
        canShoot = true;
    }

    private void Scale()
    {
        //munition.transform.localScale = munition.transform.localScale * 2;
    }

}
