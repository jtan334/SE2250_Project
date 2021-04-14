using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyerBeltMovement : MonoBehaviour
{
    public bool left;
    public float speed = 75f;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(left)
                collision.attachedRigidbody.AddForce(new Vector2(-speed, 0));
            else
                collision.attachedRigidbody.AddForce(new Vector2(speed, 0));
        }
    }
}
