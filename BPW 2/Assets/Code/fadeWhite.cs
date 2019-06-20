using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeWhite : MonoBehaviour
{
    public GameObject fadeWhiteUI;
    public AudioSource beamSound;

    public void fadeToWhite()
    {
        fadeWhiteUI.SetActive(true);
        beamSound.Play();
    }
}
