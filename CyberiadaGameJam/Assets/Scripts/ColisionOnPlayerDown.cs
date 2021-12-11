using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColisionOnPlayerDown : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            PlayerMovement.isOnGround = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision){
        PlayerMovement.isOnGround = false;
    }
}
