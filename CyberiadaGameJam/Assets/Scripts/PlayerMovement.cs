using UnityEngine;
using System.Collections;
public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D playerBody;
    private CapsuleCollider2D playerCollider;
    private float horizontal;

    [SerializeField] private float jumpForce;

    [SerializeField] private float velocity;

    public static bool isOnGround;
    
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (isOnGround && Input.GetKeyDown(KeyCode.Space))
        {
            playerBody.velocity = Vector2.up * jumpForce;
            isOnGround = false;
        }
    }

    void FixedUpdate()
    {
        playerBody.velocity = new Vector2(horizontal * velocity, playerBody.velocity.y); 
    }
}

