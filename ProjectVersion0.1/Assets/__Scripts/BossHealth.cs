using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
	public Animator animator;
	public int health = 100;

	public void TakeDamage(int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Debug.Log("Boss Dead!");

		animator.SetBool("IsDead", true);
	}


	public void DeleteBoss()
    {
		Destroy(gameObject);
	}
}