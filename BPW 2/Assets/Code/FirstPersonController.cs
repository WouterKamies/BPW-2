﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof (GravityBody))]
public class FirstPersonController : MonoBehaviour {
	
	public float mouseSensitivityX = 1;
	public float mouseSensitivityY = 1;
	public float walkSpeed = 6;
	public float jumpForce = 220;
	public LayerMask groundedMask;
	
	bool grounded;
	Vector3 moveAmount;
	Vector3 smoothMoveVelocity;
	float verticalLookRotation;
	Transform cameraTransform;
    Rigidbody rigidbody;
	
	
	void Awake()
    {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		cameraTransform = Camera.main.transform;
		rigidbody = GetComponent<Rigidbody> ();
        //StartCoroutine(Sprint());
	}

    void Update()
    {
		
		transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSensitivityX);
		verticalLookRotation += Input.GetAxis("Mouse Y") * mouseSensitivityY;
		verticalLookRotation = Mathf.Clamp(verticalLookRotation,-60,60);
		cameraTransform.localEulerAngles = Vector3.left * verticalLookRotation;
		
		float inputX = Input.GetAxisRaw("Horizontal");
		float inputY = Input.GetAxisRaw("Vertical");
		
		Vector3 moveDir = new Vector3(inputX,0, inputY).normalized;
		Vector3 targetMoveAmount = moveDir * walkSpeed;
		moveAmount = Vector3.SmoothDamp(moveAmount,targetMoveAmount,ref smoothMoveVelocity,.15f);
	
		if (Input.GetButtonDown("Jump"))
        {
            if (grounded)
            {
                rigidbody.AddForce(transform.up * jumpForce);
            }
		}
		
		Ray ray = new Ray(transform.position, -transform.up);
		RaycastHit hit;
		
		if (Physics.Raycast(ray, out hit, 1 + .1f , groundedMask))
        {
			grounded = true;
            Debug.Log("Grounded");
		}
		else {
			grounded = false;
            Debug.Log("Airborn");
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //coroutine sprint();
        }
		
	}

    //IEnumerator Sprint ()
    //{
        //double speed
        //waitforseconds
        //normal speed
        //cooldown
    //}
    

    void FixedUpdate() {
		Vector3 localMove = transform.TransformDirection(moveAmount) * Time.fixedDeltaTime;
		rigidbody.MovePosition(rigidbody.position + localMove);
	}
}
