using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private GameObject _teleportA;
    private GameObject _teleportB;

    public bool leftOrRightA;
    public bool leftOrRightB;

    void Awake()
    {
        _teleportA = gameObject.transform.GetChild(0).gameObject;
        _teleportB = gameObject.transform.GetChild(1).gameObject;
        print(_teleportA.name);
        print(_teleportB.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            collision.attachedRigidbody.transform.position = _teleportB.transform.position;
            if (leftOrRightA)
            {
                GoRight();
            }
            else
            {
                GoLeft();
            }
        }
        if (collision.gameObject.tag == "Player" && collision.gameObject == _teleportB)
        {
            if (leftOrRightB)
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
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x - 40, collision.attachedRigidbody.velocity.y);
        }
        void GoRight()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x + 40, collision.attachedRigidbody.velocity.y);
        }
    }
}
