using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootLaserObjects : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    float bulletSpeed;

    public Transform firePoint;

    


    private void Update()
    {
        if (Input.GetMouseButton(0))
        {

            Shoot();
        }
    }


    private void Shoot()
    {

        GameObject bulletClone = Instantiate(bullet);
        bulletClone.transform.position = new Vector3(0, 0, 0);
        bulletClone.transform.rotation = Quaternion.Euler(0, 0, FirePoint.lookAngle);
        bulletClone.GetComponent<Rigidbody2D>().velocity = firePoint.right * bulletSpeed;
        

    }
}


