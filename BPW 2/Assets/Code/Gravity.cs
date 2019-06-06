using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody rb;
    public float gravity;

    public void OnTriggerStay(Collider other)
    {
    
        if (other.gameObject.tag == "Gravity")
        {

            Vector3 toCenter = other.transform.position - transform.position;
            toCenter.Normalize();

            rb.AddForce(toCenter * gravity, ForceMode.Acceleration);

            Quaternion quaternion = Quaternion.FromToRotation(transform.up, -toCenter);

            quaternion = quaternion * transform.rotation;

            transform.rotation = Quaternion.Slerp(transform.rotation, quaternion, 1);

        }

    }

}
