using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PistolGun : MonoBehaviour
{


    [SerializeField]
    GameObject bullet;

    [SerializeField]
    Transform Muzzle;

    [SerializeField]
    float bulletSpeed;

    [SerializeField]
    float fireRate;

    public static float lastShot = 0.0f;

    public static float lookAngle;
    

    private void Update()
    {

        if (Input.GetMouseButton(0) && GameControler.gameIsPaused == false)
        {
            if (Time.time > fireRate + lastShot)
            {
                Shoot();
                lastShot = Time.time;
            }
        }
        
    }


    private void Shoot()
    {
     
        GameObject bulletClone = Instantiate(bullet, Muzzle.position, Muzzle.rotation);
        bulletClone.GetComponent<Rigidbody2D>().velocity = Muzzle.right * bulletSpeed;


    }
}


