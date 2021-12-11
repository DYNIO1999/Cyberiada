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

    private Vector2 lookDirection;
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

        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, lookAngle -90);



        if (lookAngle - 90f > 0 || lookAngle - 90f < -180)
        {

            PlayerSprite.flipX = true;

            lookingLeft = true;

        }
        else if (lookAngle - 90f < 0 || lookAngle - 90f > -180 && lookingLeft == true)
        {

            PlayerSprite.flipX = false;
            lookingLeft = false;
           
        }

        if (Input.GetMouseButton(0))
        {

            Shoot();
        }
    }


    private void Shoot()
    {

        GameObject bulletClone = Instantiate(bullet, Muzzle.position, Muzzle.rotation);

        bulletClone.GetComponent<Rigidbody2D>().velocity = Muzzle.up * bulletSpeed;
      //  Script missingScript = bulletClone.gameObject.AddComponent<Script>();


    }
}


