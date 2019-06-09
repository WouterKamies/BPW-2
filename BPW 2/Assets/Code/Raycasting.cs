using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    private GameObject raycastedObj;
    public GameObject item;

     public int rayLength = 10;
     public LayerMask Interaction;

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, Interaction.value))
        {
            if (hit.collider.CompareTag("Object"))
            {
                raycastedObj = hit.collider.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Debug.Log("Pickup");
                    raycastedObj.SetActive(false);
                    item.SetActive(true);

                }
            }
        }
    }
}
