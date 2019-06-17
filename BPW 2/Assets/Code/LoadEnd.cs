using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEnd : MonoBehaviour
{
    public void loadEndScene()
    {
        SceneManager.LoadScene("End");
    }
}
