using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShooted : MonoBehaviour
{
    [SerializeField]
    private float movespeed;

    [SerializeField]
    private float limitLeft;

    [SerializeField]
    private float limitRight;

    private bool moveRight;

    public static bool buttonIsShooted;

    void Start()
    {
        buttonIsShooted = false;
    }

    void FixedUpdate()
    {
        if (transform.position.x < limitLeft)
            moveRight = true;

        if (transform.position.x > limitRight)
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

        if(buttonIsShooted){
            Object.Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            buttonIsShooted = true;
        }
    }
}
