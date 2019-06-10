using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public static bool IsPaused;
    public GameObject pauseMenuUI;
    public GameObject cameraScript;
    public GameObject lookingScript;
    public GameObject crossHair;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
            
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        cameraScript.GetComponent<Raycasting>().enabled = true;
        lookingScript.GetComponent<FirstPersonController>().enabled = true;
        crossHair.SetActive(true);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        cameraScript.GetComponent<Raycasting>().enabled = false;
        lookingScript.GetComponent<FirstPersonController>().enabled = false;
        crossHair.SetActive(false);
    }

    public void backToMain()
    {
        SceneManager.LoadScene("MainMenu");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
