using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    static public PlayerCombat C;

    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    //Changed
    //public int attackDamage = 40;

    private int attackDamage = 40;
    public int AttackDamage
    {
        get { return attackDamage; }
        set { attackDamage = value; }
    }

    private void Start()
    {
        // Singleton check
        if (C == null)
        {
            C = this;
        }
        else
        {
            Debug.LogError("There can not be one Player Combat Script!");
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && (PauseMenu.GAMEISPAUSED == false))
        {
            Attack();
        }
    }


    void Attack()
    {
        // Play an attack animation
        animator.SetTrigger("Attack");

        // Detect enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        // Damage them
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}