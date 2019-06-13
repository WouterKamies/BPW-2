using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMenu : MonoBehaviour
{
    public gameManager gameManager;

    void backToMenu()
    {
        gameManager.LoadMenu();
    }
}
