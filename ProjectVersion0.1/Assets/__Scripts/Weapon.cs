using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectile;
    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")&&(PauseMenu.GAMEISPAUSED==false))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        //animator.SetTrigger("Attack");
        Instantiate(projectile, firePoint.position, firePoint.rotation);
    }
}
