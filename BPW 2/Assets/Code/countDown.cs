using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class countDown : MonoBehaviour
{
    public int timeLeft = 5;
    public Text countdownText;
    public Text countdownText2;
    public gameManager gameManager;

    void Start()
    {
        StartCoroutine("LoseTime");
    }

    void Update()
    {
        countdownText.text = ("Debris storm " + timeLeft + "");
        countdownText2.text = ("Debris storm " + timeLeft + "");

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            //gameManager.levelComplete();
        }

        if (timeLeft == 3)
        {
            gameManager.meteorRainStop();
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
