using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject startUI;
    public GameObject deathUI;
    public GameObject player;
    public GameObject spawner;
    public GameObject signalUI;
    public GameObject noSignalUI;
    public GameObject buddy;
    public GameObject timer;
    public GameObject beam;
    public GameObject fadeToWhiteUI;
    public GameObject interfaceUI;

    void Awake()
    {
        startUI.SetActive(true);
        spawner.SetActive(false);
        timer.GetComponent<countDown>().enabled = false;
        timer.SetActive(false);
    }

    public void playerDeath()
    {
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        player.GetComponent<Rigidbody>().mass = .1f;
        deathUI.SetActive(true);
        meteorRainStop();
        timer.GetComponent<countDown>().enabled = false;
        timer.SetActive(false);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void meteorRainStart()
    {
        spawner.SetActive(true);
        timer.GetComponent<countDown>().enabled = true;
        timer.SetActive(true);
    }

    public void meteorRainStop()
    {
        spawner.SetActive(false);
    }

    public void buddyDialogue()
    {
        StartCoroutine(firstDialogue());
    }

    public void levelComplete()
    {
        timer.GetComponent<countDown>().enabled = false;
        timer.SetActive(false);
        Debug.Log("You survived");
        beamMeUp();
    }

    public void beamMeUp()
    {
        StartCoroutine(generateBeam());
    }

    IEnumerator generateBeam()
    {
        yield return new WaitForSeconds(5);
        beam.SetActive(true);
        beam.GetComponent<Animator>().enabled = true;
        fadeToWhiteUI.SetActive(true);
        yield return new WaitForSeconds(15);
        beam.SetActive(false);
        interfaceUI.GetComponent<Animator>().enabled = true;
    }

    IEnumerator firstDialogue()
    {
        noSignalUI.SetActive(false);
        signalUI.SetActive(true);
        yield return new WaitForSeconds(2);
        Debug.Log("Buddy talks");
        meteorRainStart();
    }
}
