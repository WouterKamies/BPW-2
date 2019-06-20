using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    public Material on;
    public Material off;
    public GameObject button;

    public void startFlicker()
    {
        //button.GetComponent<Renderer>().material = on;
        StartCoroutine(flickerLight());
    }
    public void stopFlicker()
    {
        StopCoroutine(flickerLight());
        button.GetComponent<Collider>().enabled = false;
        button.GetComponent<Renderer>().material = on;
    }

    IEnumerator flickerLight()
    {
        while (true)
        {
            button.GetComponent<Renderer>().material = on;
            yield return new WaitForSeconds(1);
            button.GetComponent<Renderer>().material = off;
            yield return new WaitForSeconds(1);
        }
        
    }
}
