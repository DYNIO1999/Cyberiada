using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCannonShoot : MonoBehaviour
{

    [SerializeField]
    GameObject bullet;

    [SerializeField]
    float bulletSpeed;

    [SerializeField]
    float fireRate;

    private float lastShot = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > fireRate + lastShot)
        {
            Shoot();
            lastShot = Time.time;
        }
        
    }
    private void Shoot()
    {

        GameObject bulletClone = Instantiate(bullet, transform.position, transform.rotation);
        Vector2 velocity = new Vector2(transform.right.x,transform.right.y);
        bulletClone.GetComponent<Rigidbody2D>().velocity = -velocity*bulletSpeed;


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("GroundToDestroy"))
        {
            Object.Destroy(gameObject);
        }
    }

}
