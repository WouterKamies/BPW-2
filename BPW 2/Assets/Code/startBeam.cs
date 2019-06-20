using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBeam : MonoBehaviour
{
    public gameManager gameManager;
    public GameObject ambience;

    public void commenceBeaming()
    {
        gameManager.beamMeUp();
        ambience.SetActive(false);
    }
}
