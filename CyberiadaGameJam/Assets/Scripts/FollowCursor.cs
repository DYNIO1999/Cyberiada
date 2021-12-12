using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{

    public static float lookAngle;
    void Update()
    {

        Vector3 pp = transform.position;
        Vector3 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mp.z = 0;
        Vector3 gm = mp - pp;
        gm.Normalize();

        lookAngle = Mathf.Atan2(gm.y, gm.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, lookAngle);
    }
}
