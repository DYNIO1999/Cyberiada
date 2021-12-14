using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSound : MonoBehaviour
{


    [SerializeField]
    AudioSource levelAudio;

    [SerializeField]
    AudioSource winAudio;

    private void OnEnable()
    {
        if (levelAudio.isPlaying == true)
        {
            levelAudio.Stop();


        }

        winAudio.Play();

    }
}
