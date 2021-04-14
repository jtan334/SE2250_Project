using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    int currentHealth;
    public Experience exp;

    public float distanceRight = 7.5f;
    public float distanceLeft = 4.5f;

    private Vector3 MovingDirection = Vector3.left;


    // Start is called before the first frame update
    void Start()
    {
        exp = new Experience();
        currentHealth = maxHealth;
        exp.SetExperience(0);
    }

    void Update()
    {
        UpdateMovement();
    }

    public virtual void UpdateMovement()
    {
        if (this.transform.position.x > distanceRight)
        {
            MovingDirection = Vector3.left;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }
        else if (this.transform.position.x < distanceLeft)
        {
            MovingDirection = Vector3.right;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        }
        this.transform.Translate(MovingDirection * Time.smoothDeltaTime * 2);

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
        Debug.Log("Enemy Died!");

        Destroy(gameObject);

        // Die animation
        animator.SetBool("IsDead", true);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
