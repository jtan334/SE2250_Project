using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyerBeltMovement : MonoBehaviour
{
    void OnTriggerStay(Collider collision)
    {
        print("Pog");
        collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x + 5, collision.attachedRigidbody.velocity.y);
    }
}
