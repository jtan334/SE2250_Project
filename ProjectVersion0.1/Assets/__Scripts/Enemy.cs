using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    //Changed from int to public int for inheritance
    public int currentHealth;
    public Experience exp;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        exp.SetExperience(0);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Play hurt animation
        animator.SetTrigger("Hurt");

        if (currentHealth < 0)
        {
            Die();
            exp.Exprience += 20;
            exp.Score += 20;
            exp.SetExperience(exp.Exprience);
        }  
    }

    void Die()
    {
        Destroy(gameObject);
        Debug.Log("Enemy Died!");

        // Die animation
        animator.SetBool("IsDead", true);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
