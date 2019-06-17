using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeBlack : MonoBehaviour
{
    public GameObject fadetoblackUI;

    public void FadeToBlack()
    {
        fadetoblackUI.SetActive(true);
    }
}
