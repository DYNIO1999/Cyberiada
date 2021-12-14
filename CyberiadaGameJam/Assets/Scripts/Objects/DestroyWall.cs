using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    void Update()
    {
        if(ButtonShooted.buttonIsShooted){
            Object.Destroy(gameObject);
        }
        
    }
}
