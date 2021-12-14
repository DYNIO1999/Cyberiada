using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private bool isFalling;
    [SerializeField]
    private float endTime;
    private float timer;

    private Rigidbody2D fallingRB;
    void Start()
    {
        fallingRB=GetComponent<Rigidbody2D>();
        isFalling = false;
        timer = 0;
    }
    void Update()
    {
        if (isFalling)
        {
            timer = timer + Time.deltaTime;
            if (timer > endTime)
            {
                fallingRB.gravityScale=1;
                isFalling=false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            isFalling = true;
        }
        if(collision.collider.CompareTag("Enemy")){
            Object.Destroy(gameObject);
        }
    }
}
