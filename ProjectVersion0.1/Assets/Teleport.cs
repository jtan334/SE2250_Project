using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    private GameObject _teleportThis;
    public GameObject teleportOther;

    public bool leftOrRightA;
    void Start()
    {
        _teleportThis = gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.attachedRigidbody.transform.position = teleportOther.transform.position;
            if (leftOrRightA)
            {
                GoRight();
            }
            else
            {
                GoLeft();
            }
        }


        void GoLeft()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x - 50, collision.attachedRigidbody.velocity.y);
        }
        void GoRight()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x + 50, collision.attachedRigidbody.velocity.y);
        }
    }

}
