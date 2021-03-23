using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    int currentHealth;
     private Vector3 MovingDirection = Vector3.left*2;
   

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

    void Die()
    {
        Debug.Log("Enemy Died!");

        // Die animation
        animator.SetBool("IsDead", true);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
    void Update () {    
         UpdateMovement ();
         animator.SetTrigger("Run");
     }
 
     void UpdateMovement(){
         if (this.transform.position.x > 7.5f) {
             MovingDirection = Vector3.left;
             gameObject.GetComponent<SpriteRenderer> ().flipX = false;
 
         } else if (this.transform.position.x < 4.5f) { 
             MovingDirection = Vector3.right;
             gameObject.GetComponent<SpriteRenderer> ().flipX = true;
 
         } 
         this.transform.Translate (MovingDirection * Time.smoothDeltaTime);
         
     }
}
