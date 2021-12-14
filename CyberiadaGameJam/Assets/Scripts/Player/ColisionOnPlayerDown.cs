using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColisionOnPlayerDown : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayerMask;
    [SerializeField] private int legType;

    void Update(){
        if(legType ==1){
        PlayerMovement.isOnGroundLeft=IsGrounded();
        }
        if(legType ==2){
        PlayerMovement.isOnGroundMiddle = IsGrounded();
        }
        if(legType ==3){
        PlayerMovement.isOnGroundRight = IsGrounded();
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D rayCastHit =Physics2D.Raycast(transform.position,Vector2.down,0.1f,groundLayerMask);
        return rayCastHit.collider!=null;
    }
}
