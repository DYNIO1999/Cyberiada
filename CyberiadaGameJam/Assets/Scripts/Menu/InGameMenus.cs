using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenus : MonoBehaviour
{

    public void UnPauseGame()
    {
        GameControler.gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void ToMainMenu()
    {

        SceneManager.LoadScene(0);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
