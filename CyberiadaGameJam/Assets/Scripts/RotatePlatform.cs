using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    void Update()
    {
        transform.Rotate(new Vector3(0,0,1)* rotationSpeed * Time.deltaTime,Space.Self);
    }
}
