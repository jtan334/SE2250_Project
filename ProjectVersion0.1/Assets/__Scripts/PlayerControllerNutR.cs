using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerNutR : MonoBehaviour
{
    public Rigidbody2D playerRigidBody;

    public static PlayerControllerNutR Player;

    public Rigidbody2D rb;

    void Awake()
    {
        if (Player == null)
        {
            Player = this;
        }
        else
        {
            Debug.LogError("Hero.Awake() - Attempted to assign second Her.S!");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(5, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-5, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
    }
}
