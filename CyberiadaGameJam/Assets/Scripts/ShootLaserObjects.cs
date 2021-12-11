using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootLaserObjects : MonoBehaviour
{
    [SerializeField]
    Transform playerTransform;


    [SerializeField]
    SpriteRenderer PlayerSprite;

    [SerializeField]
    GameObject bullet;

    [SerializeField]
    Transform Muzzle;
    
    [SerializeField]
    float bulletSpeed;

    private float lookAngle;
    private bool lookingLeft;

    private void Update()
    {
        Vector3 pp = playerTransform.position;
        Vector3 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mp.z = 0;
        Vector3 gm = mp - pp;
        gm.Normalize();
        
        transform.position = new Vector3(gm.x, gm.y, 0) + pp;
      
        lookAngle = Mathf.Atan2(gm.y, gm.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, lookAngle -90);


        if (Input.GetMouseButton(0))
        {

            Shoot();
        }
    }


    private void Shoot()
    {
        GameObject bulletClone = Instantiate(bullet, Muzzle.position, Muzzle.rotation);
        bulletClone.GetComponent<Rigidbody2D>().velocity = Muzzle.up * bulletSpeed;
    }
}


