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

    public static bool lookingLeft;
    private bool playerJumped;
    public static bool playerMovingRight;
    public static Vector3 playerPosition;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); 

        if (isOnGround && Input.GetKeyDown(KeyCode.Space))
        {

            playerJumped = true;
            
            isOnGround = false;
        }

        if (horizontal > 0)
        {
            playerMovingRight = true;
        }
        if(horizontal < 0)
        {
            playerMovingRight = false;
        }
        playerPosition = transform.position;
    }

    void FixedUpdate()
    {
        playerBody.velocity = new Vector2(horizontal * velocity, playerBody.velocity.y);

        if (playerJumped)
        {
            playerBody.velocity = Vector2.up * jumpForce;
            playerJumped = false;
        }
    }
}

