using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    static public PlayerHealth H;

    public Animator animator;

    public static int MAXHEALTH = 100;

    public Text healthBar;
    int currentHealth;

    // Takes damage afte rgetting hit by boss
    public void TakeDamage(int damage)
    {
        Debug.Log("Hit");

        currentHealth -= damage;

        animator.SetTrigger("Hurt");
        healthBar.text = "Health: " + currentHealth; 

        healthBar.text = "Health: " + currentHealth;

        if (currentHealth < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    // Takes damage after colliding with enemies
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Hit");

            currentHealth = currentHealth - 20;

            animator.SetTrigger("Hurt");
            

            if (currentHealth <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Starts the health bar at max health
         healthBar.text = "Health: " + MAXHEALTH;  
        // Singleton check
        if (H == null)
        {
            H = this;
        }
        else
        {
            Debug.LogError("There can not be one Player Health Script!");
        }

        currentHealth = MAXHEALTH;
    }
}
