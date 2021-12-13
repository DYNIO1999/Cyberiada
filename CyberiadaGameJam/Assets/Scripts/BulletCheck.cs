using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCheck : MonoBehaviour
{

    
    public float range_limit = 100;
    int bounce_count = 0;

    
    private Vector2 prd;

    void Start(){
         prd= GetComponent<Rigidbody2D>().velocity;
    }
    private void BounceOff(Collision2D collision)
    {
        float zwrot = (Vector2.Dot(prd,collision.contacts[0].normal));

        if(prd.x>0){
            prd = new Vector2(zwrot, prd.y);
        }else{
            prd = new Vector2(zwrot*(-1), prd.y);
        }
        GetComponent<Rigidbody2D>().velocity = prd;
    }

    void Update()
    {
        
        if(Mathf.Abs(transform.position.x) > range_limit || Mathf.Abs(transform.position.y) > range_limit)
        {
            Object.Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.CompareTag("Enemy"))
        {
            Object.Destroy(gameObject);
        }



        if (collision.collider.CompareTag("Wall"))
        {
            bounce_count++;
            if (bounce_count > 1)
            {
                Object.Destroy(gameObject);
            }
            BounceOff(collision);
        }

    }
  
}
