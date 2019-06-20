using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeBlack : MonoBehaviour
{
    public GameObject fadetoblackUI;
    public GameObject player;
    public GameObject canvas;

    public void FadeToBlack()
    {
        fadetoblackUI.SetActive(true);
        player.GetComponent<FirstPersonController>().enabled = false;
        canvas.GetComponent<PauseScreen>().enabled = false;
    }
}
