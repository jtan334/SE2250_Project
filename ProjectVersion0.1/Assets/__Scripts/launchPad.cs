using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchPad : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x, /* System.Math.Abs(collision.attachedRigidbody.velocity.y) + */25);
        }
    }
}
