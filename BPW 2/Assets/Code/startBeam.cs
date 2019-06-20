using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBeam : MonoBehaviour
{
    public gameManager gameManager;

    public void commenceBeaming()
    {
        gameManager.beamMeUp();
    }
}
