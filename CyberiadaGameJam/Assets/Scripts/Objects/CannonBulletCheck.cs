using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBulletCheck : MonoBehaviour
{

    [SerializeField]
    private float range_limit;

    [SerializeField]
    private int max_bounce_count;

    int bounce_count = 0;


    void Update()
    {
        if (transform.position.x > PlayerMovement.playerPosition.x + range_limit || transform.position.x < PlayerMovement.playerPosition.x - range_limit
        || transform.position.y > PlayerMovement.playerPosition.y + range_limit || transform.position.y < PlayerMovement.playerPosition.y - range_limit)
        {
            Object.Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.collider.CompareTag("Wall")){
            bounce_count++;
            if (bounce_count > max_bounce_count)
            {
                Object.Destroy(gameObject);
            }
        }
        if(collision.collider.CompareTag("Player")){
            Object.Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Ground"))
        {
            bounce_count++;
            if (bounce_count > max_bounce_count)
            {
                Object.Destroy(gameObject);
            }
        }
        if(collision.collider.CompareTag("Enemy"))
        {
            Object.Destroy(gameObject);
        }

        if (collision.collider.CompareTag("Bullet"))
        {
            bounce_count++;
            if (bounce_count > max_bounce_count)
            {
                Object.Destroy(gameObject);
            }
        }
    }
}
