using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]
    GameObject deadPlayer;

    [SerializeField]
    GameObject deathMenu;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("You died");
            Instantiate(deadPlayer, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            //Time.timeScale = 0;
           // GameControler.gameIsPaused = true;
            deathMenu.SetActive(true);

        }
    }
}
