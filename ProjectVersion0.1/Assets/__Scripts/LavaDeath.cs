﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaDeath : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // Destroy's enemy if they hit the lava
        if (collision.gameObject.tag == "Enemy")
        {
           // Destroy(collision.gameObject);
        }
    }
}
