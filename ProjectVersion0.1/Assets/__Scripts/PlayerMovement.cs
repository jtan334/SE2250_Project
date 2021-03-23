using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	static PlayerMovement M;

	public PlayerControllerNutR controller;
	public Animator animator;


	public float runSpeed = 100f;

	float horizontalMove = 0f;
	bool jump = false;

    private void Start()
    {
		// Singleton check
		if (M == null)
		{
			M = this;
		}
		else
		{
			Debug.LogError("There can not be one Player Movement Script!");
		}
	}

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