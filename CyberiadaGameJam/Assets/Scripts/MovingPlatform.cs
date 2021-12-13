using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private float movespeed;

    [SerializeField]
    private float limitLeft;

    [SerializeField]
    private float limitRight;

    private bool moveRight;

    void FixedUpdate()
    {
        if (transform.position.x < limitLeft)
            moveRight = true;

        if(transform.position.x > limitRight)
        {
            moveRight = false;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, transform.position.y);
        }


    }
}
