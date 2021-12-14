using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosingSound : MonoBehaviour
{
    [SerializeField]
    AudioSource levelAudio;

    [SerializeField]
    AudioSource loseMenu;

    private void OnEnable()
    {
        if(levelAudio.isPlaying == true)
        {
            levelAudio.Stop();

            
        }

        loseMenu.Play();

    }

}
