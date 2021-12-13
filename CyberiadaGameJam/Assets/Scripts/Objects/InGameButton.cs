using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameButton : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") || collision.CompareTag("Box"))
        {
           
            //Do_Something

        }

    }   

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") || collision.CompareTag("Box"))
        {

            //Stop_Doing_Something

        }

    }
}
