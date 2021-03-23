﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public PlayerControllerNutR controller;
	public Animator animator;


	public float runSpeed = 100f;

	float horizontalMove = 0f;
	bool jump = false;

	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed",Mathf.Abs( horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
	}

	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		jump = false;
	}
}