using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject fadeout;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fadeout.SetActive(true);
            StartCoroutine(loadLevel());
        }
    }

    IEnumerator loadLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Level");
    }
}
