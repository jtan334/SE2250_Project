using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;  
    
    int currentHealth;
    public float distanceRight =7.5f;
    public float distanceLeft =4.5f;

    private Vector3 MovingDirection = Vector3.left;
   

    // Start is called before the first frame update
    
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

    public virtual void Die()
    {
        Debug.Log("Enemy Died!");

        // Die animation
        animator.SetBool("IsDead", true);

        Destroy(gameObject);

        // The code below is still in progess. It's meant to leave the enemy corpses in the back ground
        /*Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;*/
    }
    void Update () {    
         UpdateMovement ();
     }
 
     public virtual void UpdateMovement(){
         if (this.transform.position.x > distanceRight) {
             MovingDirection = Vector3.left;
             gameObject.GetComponent<SpriteRenderer> ().flipX = false;
 
         } else if (this.transform.position.x < distanceLeft) { 
             MovingDirection = Vector3.right;
             gameObject.GetComponent<SpriteRenderer> ().flipX = true;
 
         } 
         this.transform.Translate (MovingDirection * Time.smoothDeltaTime*2);
         
     }
}
