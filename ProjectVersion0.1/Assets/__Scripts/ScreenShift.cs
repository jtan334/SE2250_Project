using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShift : MonoBehaviour
{
    public GameObject ViewCamera;
    private Vector3 currentPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentPos = ViewCamera.transform.position;

        if (collision.gameObject.tag == "Player")
        {
            //up
            if (this.transform.position.y - currentPos.y > 10)
            {
                ViewCamera.transform.position = currentPos + new Vector3(0, +20, 0);
            }
            //down
            if (currentPos.y - this.transform.position.y > 10)
            {
                ViewCamera.transform.position = currentPos + new Vector3(0, -20, 0);
            }
            //left
            if (currentPos.x - this.transform.position.x > 20)
            {
                ViewCamera.transform.position = currentPos + new Vector3(-40, 0, 0);
            }
            //right
            if (this.transform.position.x - currentPos.x > 20)
            {
                ViewCamera.transform.position = currentPos + new Vector3(40, 0, 0);
            }
        }
    }
}
