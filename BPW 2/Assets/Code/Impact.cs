using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour
{
    public gameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Planet"))
        {
            Debug.Log("Impact");
            gameObject.GetComponent<MeteorMove>().enabled = false;
            gameObject.GetComponentInChildren<Renderer>().enabled = false;

        }

        if (other.CompareTag("Player"))
        {
            gameManager.playerDeath();
            Debug.Log("You died");
        }
    }
}
