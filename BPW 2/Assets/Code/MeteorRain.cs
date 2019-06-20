using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorRain : MonoBehaviour
{
    public gameManager gameManager;
    public AudioSource levelSong;

    public void beginRain()
    {
        gameManager.meteorRainStart();
        levelSong.Play();
    }
}
