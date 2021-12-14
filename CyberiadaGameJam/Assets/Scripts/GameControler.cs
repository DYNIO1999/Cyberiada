using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public static bool gameIsPaused;

    [SerializeField]
    GameObject pauseMenu;

    [SerializeField]
    GameObject deathMenu;

    [SerializeField]
    GameObject winMenu;

    [SerializeField]
    GameObject deathMenus;

    [SerializeField]
    GameObject winMenus;

    private void Awake()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        pauseMenu.SetActive(false);
        deathMenu.SetActive(false);
        winMenu.SetActive(false);
        deathMenus.SetActive(false);
        winMenus.SetActive(false);


    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && gameIsPaused == false)
        {
            Debug.Log("Pauza");
            
            PauseGame();
        }

        else if(Input.GetKeyDown(KeyCode.Escape) && gameIsPaused == true)
        {
            Debug.Log("UnPauzuje");
            UnPauseGame();
        }

    }

    private void PauseGame()
    {
        Debug.Log("Pauzujeeeee");
        gameIsPaused = true;
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);

    }

    private void UnPauseGame()
    {
        Debug.Log("Wlaczaam");
        gameIsPaused = false;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}
