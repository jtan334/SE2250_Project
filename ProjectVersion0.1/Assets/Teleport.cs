using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    private GameObject _teleportThis;
    private GameObject _teleportOther;

    public bool leftOrRightA;
    public bool leftOrRightB;
    void Start()
    {
        _teleportThis = gameObject;
        _teleportOther = gameObject.transform.parent.gameObject.transform.GetChild(0).gameObject;
        if (_teleportOther == _teleportThis)
        {
            _teleportOther = gameObject.transform.parent.gameObject.transform.GetChild(1).gameObject;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(gameObject.name);
        if (collision.gameObject.tag == "Player" && collision.gameObject == _teleportThis)
        {
            collision.attachedRigidbody.transform.position = _teleportOther.transform.position;
            if (leftOrRightA)
            {
                GoRight();
            }
            else
            {
                GoLeft();
            }
        }
        if (collision.gameObject.tag == "Player" && collision.gameObject == _teleportOther)
        {
            collision.attachedRigidbody.transform.position = _teleportThis.transform.position;
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
