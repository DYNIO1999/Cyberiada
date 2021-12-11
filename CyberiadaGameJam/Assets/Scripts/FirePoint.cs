using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : MonoBehaviour
{
    Transform firePoint;

    Vector2 lookDirection;
    public static float lookAngle;

    private void Update()
    {
        lookDirection = Camera.main.WorldToScreenPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        firePoint.rotation = Quaternion.Euler(0, 0, lookAngle);


    }

}
