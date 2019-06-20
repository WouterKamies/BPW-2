using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    private GameObject raycastedObj;
    public GameObject item;
    public gameManager gameManager;
    public GameObject button;
    public AudioSource radioSound;

    public int rayLength = 10;
    public LayerMask Interaction;

    public Material on;
    public Material off;

    private void Awake()
    {
        button.GetComponent<Renderer>().material = off;
    }

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, Interaction.value))
        {
            if (hit.collider.CompareTag("Radio"))
            {
                raycastedObj = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    radioSound.Play();
                    button.GetComponent<Renderer>().material = on;
                    item.SetActive(true);
                    gameManager.buddyDialogue();
                    
                }
            }
        }
    }
}
