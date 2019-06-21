using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeBlack : MonoBehaviour
{
    public gameManager gameManager;
    public GameObject player;
    public GameObject canvas;

    public void load ()
    {
        gameManager.LoadCredits();
        player.GetComponent<FirstPersonController>().enabled = false;
        canvas.GetComponent<PauseScreen>().enabled = false;
    }
}
