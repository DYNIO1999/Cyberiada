using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootLaserObjects : MonoBehaviour
{
    [SerializeField]
    Transform playerTransform;

    [SerializeField]
    GameObject bullet;

    [SerializeField]
    Transform Muzzle;

    [SerializeField]
    float bulletSpeed;

    [SerializeField]
    float fireRate;

    private float lastShot = 0.0f;

    public static float lookAngle;
    public static bool lookingLeft;

    private void Update()
    {
        Vector3 pp = playerTransform.position;
        Vector3 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mp.z = 0;
        Vector3 gm = mp - pp;
        gm.Normalize();



        transform.position = new Vector3(gm.x, gm.y, 0) + pp;

        lookAngle = Mathf.Atan2(gm.y, gm.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, lookAngle);


        if (transform.rotation.z < -0.7 || transform.rotation.z > 0.7 && lookingLeft == false)
        {

            GetComponent<SpriteRenderer>().flipY = true;
            lookingLeft = true;

        }
        if ((transform.rotation.z > -0.7 && transform.rotation.z < 0.7) && lookingLeft == true)
        {
            GetComponent<SpriteRenderer>().flipY = false;
            lookingLeft = false;
        }

        if (Input.GetMouseButtonDown(0))
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

        Debug.Log(lookingLeft);

        if (!lookingLeft)
        {
            GameObject bulletClone = Instantiate(bullet, Muzzle.position += new Vector3(0f, 0.2f, 0f), Muzzle.rotation);
            bulletClone.GetComponent<Rigidbody2D>().velocity = Muzzle.right * bulletSpeed;
            Muzzle.position -= new Vector3(0f, 0.2f, 0f);
        }
        else
        {
            GameObject bulletClone = Instantiate(bullet, Muzzle.position, Muzzle.rotation);
            bulletClone.GetComponent<Rigidbody2D>().velocity = Muzzle.right * bulletSpeed;
        }
    }
}


