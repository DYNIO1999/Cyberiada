using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBulletCheck : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.collider.CompareTag("Wall")){
            Object.Destroy(gameObject);
        }
        if(collision.collider.CompareTag("Player")){
            Object.Destroy(gameObject);
        }
    }
}
