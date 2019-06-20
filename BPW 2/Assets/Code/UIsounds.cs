using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIsounds : MonoBehaviour
{
    public AudioSource UISound;
    public AudioClip hover;
    public AudioClip click;

    public void hoverSound()
    {
        UISound.PlayOneShot(hover);
    }

    public void clickSound()
    {
        UISound.PlayOneShot(click);
    }
}
