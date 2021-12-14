using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    [SerializeField]
    GameObject winScreen;

    [SerializeField]
    GameObject Player;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.SetActive(false);
            Time.timeScale = 0f;
            GameControler.gameIsPaused = true;
            winScreen.SetActive(true);
        }
    }

    
}
