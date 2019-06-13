using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject startUI;
    public GameObject deathUI;
    public GameObject player;

    void Awake()
    {
        startUI.SetActive(true);
    }

    public void playerDeath()
    {
        deathUI.SetActive(true);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
