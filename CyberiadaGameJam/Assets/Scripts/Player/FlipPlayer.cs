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
        if (((FollowCursor.rotation.z < -0.71 && FollowCursor.rotation.z >-1f) || FollowCursor.rotation.z > 0.71) && PlayerMovement.lookingLeft == false )
        {

            PlayerMovement.lookingLeft = true;

            rightPostion = transform.position;
            playerRight.SetActive(false);
            playerLeft.SetActive(true);
            transform.position = rightPostion;
        }

        if ((FollowCursor.rotation.z > -0.69 && FollowCursor.rotation.z < 0.69) && PlayerMovement.lookingLeft == true )
        {

            PlayerMovement.lookingLeft = false;

            leftPostion = transform.position;
            playerLeft.SetActive(false);
            playerRight.SetActive(true);
            transform.position = leftPostion;
        }
    }
}
