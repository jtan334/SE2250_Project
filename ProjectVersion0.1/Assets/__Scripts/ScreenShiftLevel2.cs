using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShiftLevel2 : MonoBehaviour
{
    public GameObject ThisCamera;
    public GameObject OtherCamera;
    private Vector3 currentPos;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        currentPos = ThisCamera.transform.position;

        if (collision.gameObject.tag == "Player")
        {
            //up
            if (this.transform.position.y - currentPos.y > 10 && collision.attachedRigidbody.velocity.y > 0)
            {
                OtherCamera.SetActive(true);
                ThisCamera.SetActive(false);
                GoUp();
                //print("^^^");
            }
            //down
            else if (currentPos.y - this.transform.position.y > 10 && collision.attachedRigidbody.velocity.y < 0)
            {
                OtherCamera.SetActive(true);
                ThisCamera.SetActive(false);
                GoNotDown();
                //print("VVV");
            }
            //left
            else if (currentPos.x - this.transform.position.x > 20 && collision.attachedRigidbody.velocity.x < 0)
            {
                OtherCamera.SetActive(true);
                ThisCamera.SetActive(false);
                GoLeft();
                //print("<<<");
            }
            //right
            else if (this.transform.position.x - currentPos.x > 20 && collision.attachedRigidbody.velocity.x > 0)
            {
                OtherCamera.SetActive(true);
                ThisCamera.SetActive(false);
                GoRight();
                //print(">>>");
            }
            else
            {
                return;
            }
        }

        void GoUp()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x, 15);
        }
        void GoLeft()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x - 20, collision.attachedRigidbody.velocity.y);
        }
        void GoRight()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x + 20, collision.attachedRigidbody.velocity.y);
        }
        void GoNotDown()
        {
            collision.attachedRigidbody.velocity = new Vector2(collision.attachedRigidbody.velocity.x, 0-1);
        }
    }


}