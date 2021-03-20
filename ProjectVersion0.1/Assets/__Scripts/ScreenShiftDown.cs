using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShiftDown : MonoBehaviour
{
    public GameObject ViewCamera;
    private Vector3 currentPos;
    private Vector3 originalPos;

    void Awake()
    {
        originalPos = ViewCamera.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentPos = ViewCamera.transform.position;
        if (collision.gameObject.tag == "Player")
        {
            if (currentPos != originalPos)
            {
                ViewCamera.transform.position = currentPos + new Vector3(0, -20, 0);
            }
        }
    }
}
