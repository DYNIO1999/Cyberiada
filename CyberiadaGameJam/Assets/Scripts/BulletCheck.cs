using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCheck : MonoBehaviour
{


    public float range_limit = 100;
    int bounce_count = 0;


    private void BounceOff()
    {

    }

    void Update()
    {
        
        if(Mathf.Abs(transform.position.x) > range_limit || Mathf.Abs(transform.position.y) > range_limit)
        {
            Object.Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy"))
        {
            Object.Destroy(gameObject);
        }

        if (collision.CompareTag("Wall"))
        {
            bounce_count++;
            if (bounce_count > 1)
            {
                Object.Destroy(gameObject);
            }

        }
    }
}
