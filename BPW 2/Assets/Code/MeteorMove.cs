using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    public GameObject wayPoint;
    public float speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, wayPoint.transform.position, Time.deltaTime * speed);
    }
}
