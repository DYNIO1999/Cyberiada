using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShootLaserLeft : MonoBehaviour
{
    [SerializeField]
    float bulletSpeed;

    [SerializeField]
    float fireRate;

    [SerializeField]
    GameObject bullet;

    private float lastShot = 0.0f;


    BoxCollider2D cannonBoxCollider;

    void Start()
    {
        cannonBoxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {

        if (Time.time > fireRate + lastShot)
        {
            CannonShoot();
            lastShot = Time.time;
        }
    }

    void CannonShoot()
    {
        float newposX = cannonBoxCollider.size.x / 4;
        Vector3 bulletPos = new Vector3(transform.position.x - newposX, transform.position.y, transform.position.z);
        GameObject bulletClone = Instantiate(bullet, bulletPos, Quaternion.identity);
        Vector3 bulletDir = new Vector3(-1, 0, 0);
        bulletClone.GetComponent<Rigidbody2D>().velocity = bulletDir * bulletSpeed;
    }
}
