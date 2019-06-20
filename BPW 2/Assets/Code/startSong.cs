using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSong : MonoBehaviour
{
    public AudioSource starTrekSong;

    public void playSong()
    {
        starTrekSong.Play();
    }
}
