using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
	public Animator animator;
	public int maxHealth = 100;
	int currentHealth;

	void Start()
	{
		currentHealth = maxHealth;
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		// Play hurt animation
		animator.SetTrigger("Hurt");

		if (currentHealth < 0)
		{
			Die();
		}
	}

	void Die()
	{
		Debug.Log("Enemy Died!");

		// Die animation
		animator.SetBool("IsDead", true);


		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
