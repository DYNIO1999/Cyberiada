using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{

    public void LoadLevel1()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void LoadLevel2()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}
