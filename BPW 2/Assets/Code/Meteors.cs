using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteors : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Planet")
        {
            Destroy(this.gameObject);
            Debug.Log("Impact");
        }
    }
}
