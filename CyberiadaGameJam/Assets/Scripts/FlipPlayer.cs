using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipPlayer : MonoBehaviour
{

    [SerializeField]
    GameObject playerLeft;

    [SerializeField]
    GameObject playerRight;

    private Vector3 leftPostion;
    private Vector3 rightPostion;

    void Update()
    {
        if (((FollowCursor.rotation.z < -0.7 && FollowCursor.rotation.z >-1f) || FollowCursor.rotation.z > 0.7) && PlayerMovement.lookingLeft == false )
        {

            //SpriteRenderer spriteRend = GetComponent<SpriteRenderer>();
            //spriteRend.flipY = true;
            //transform.position += new Vector3(0, 0.1f,0);

            Debug.Log("Patrze w lewo! " +FollowCursor.rotation);

            PlayerMovement.lookingLeft = true;

            rightPostion = transform.position;
            playerRight.SetActive(false);
            playerLeft.SetActive(true);
            transform.position = rightPostion;
            

        }
        if ((FollowCursor.rotation.z > -0.7 && FollowCursor.rotation.z < 0.7) && PlayerMovement.lookingLeft == true )
        {

            Debug.Log("Patrze w prawo! "+FollowCursor.rotation);
            // GetComponent<SpriteRenderer>().flipY = false;
            //transform.position -= new Vector3(0, 0.1f, 0);
            PlayerMovement.lookingLeft = false;

            leftPostion = transform.position;
            playerLeft.SetActive(false);
            playerRight.SetActive(true);
            transform.position = leftPostion;
            

        }
    }
}
