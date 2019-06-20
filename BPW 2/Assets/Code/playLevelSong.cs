using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playLevelSong : MonoBehaviour
{
    public GameObject ambience;
    
    public void playAmbience()
    {
        ambience.SetActive(true);
    }
}
