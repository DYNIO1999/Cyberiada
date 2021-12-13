using UnityEngine;
using System.Collections;
public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D playerBody;
    private CapsuleCollider2D playerCollider;
    private float horizontal;

    [SerializeField] private float jumpForce;

    [SerializeField] private float velocity;

    
    Animator anim;

    public static bool isOnGroundLeft;
    public static bool isOnGroundMiddle;
    public static bool isOnGroundRight;
    public static bool lookingLeft;
    private bool playerJumped;
    public static Vector3 playerPosition;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); 

        if ((isOnGroundLeft || isOnGroundMiddle || isOnGroundRight) && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) )
        {

            playerJumped = true;
            
            isOnGroundLeft = false;
            isOnGroundMiddle = false;
            isOnGroundRight = false;
        }

        if (lookingLeft == false)
        {
            anim.SetBool("IsLeftActive", false);
        }
        else
        {
            anim.SetBool("IsLeftActive", true);
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal == 0)
        {
            anim.SetBool("IsRunningLeft", false);
            anim.SetBool("IsRunningRight", false);
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal > 0)
        {
            anim.SetBool("IsRunningRight", true);
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        if (horizontal < 0)
        {
            anim.SetBool("IsRunningLeft", true);
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

