using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public  bool gameIsPaused;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && gameIsPaused == false)
        {
            gameIsPaused = true; 
            PauseGame();
        }

        if (Input.GetKeyDown(KeyCode.Escape) && gameIsPaused == true)
        {
            gameIsPaused = false;
            UnPauseGame();
        }

    }

    private void PauseGame()
    {

        Time.timeScale = 0f;

    }

    private void UnPauseGame()
    {

        Time.timeScale = 1f;

    }
}
