using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : Enemy
{

	public float moveSpeed = 5f;
	public float frequency = 15f;
	public float magnitude = 0.5f;

	bool facingRight = true;

	Vector3 pos, localScale;

	// Use this for initialization
	void Start()
	{
		

		pos = transform.position;

		localScale = transform.localScale;

	}

	// Circular movement
	public override void UpdateMovement() {
		CheckWhereToFace();

		if (facingRight)
			MoveLeft();
		else
			MoveRight();
	}

	void CheckWhereToFace()
	{
		if (pos.x < -7f)
			facingRight = false;

		else if (pos.x > 7f)
			facingRight = true;

		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;

		transform.localScale = localScale;

	}

	void MoveRight()
	{
		pos += transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
	}

	void MoveLeft()
	{
		pos -= transform.right * Time.deltaTime * moveSpeed;
		transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
	}
}