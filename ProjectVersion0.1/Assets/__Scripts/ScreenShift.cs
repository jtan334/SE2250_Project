using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShift : MonoBehaviour
{
    public GameObject ViewCamera;
    private Vector3 currentPos;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        currentPos = ViewCamera.transform.position;

        if (collision.gameObject.tag == "Player")
        {
            //up
            if (this.transform.position.y - currentPos.y > 10 && collision.attachedRigidbody.velocity.y > 0)
            {
                ViewCamera.transform.position = currentPos + new Vector3(0, +20, 0);
                GoUp();
            }
            //down
            if (currentPos.y - this.transform.position.y > 10 && collision.attachedRigidbody.velocity.y < 0)
            {
                ViewCamera.transform.position = currentPos + new Vector3(0, -20, 0);
                GoNotDown();
            }
            //left
            if (currentPos.x - this.transform.position.x > 20 && collision.attachedRigidbody.velocity.x < 0)
            {
                ViewCamera.transform.position = currentPos + new Vector3(-40, 0, 0);
                GoLeft();
            }
            //right
            if (this.transform.position.x - currentPos.x > 20 && collision.attachedRigidbody.velocity.x > 0)
            {
                ViewCamera.transform.position = currentPos + new Vector3(40, 0, 0);
                GoRight();
            }
        }

        void GoUp()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x,15);
        }
        void GoLeft()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x - 40, collision.attachedRigidbody.velocity.y);
        }
        void GoRight()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x + 40, collision.attachedRigidbody.velocity.y);
        }
        void GoNotDown()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x, 0);
        }
    }

    
}
