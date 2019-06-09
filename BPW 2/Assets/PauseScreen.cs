using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    private bool IsPaused;
    public GameObject PauseMenu;


    private void Awake()
    {
        IsPaused = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused == true)
            {
                PauseMenu.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Debug.Log("Resumed Game");
            }

            if (IsPaused == false)
            {
                PauseMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                //StartCoroutine(Pause());
                Debug.Log("Paused Game");
            }
            
        }

        else

        if (Input.GetKeyDown(KeyCode.Escape) && IsPaused == true)
        {
            PauseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Debug.Log("Resumed Game");
            //StopCoroutine(Pause());
        }
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //IEnumerator Pause()
    //{
    //PauseGame
    //}
}
