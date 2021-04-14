using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowHorizontal : MonoBehaviour
{

    public Transform followTransform;
    public float leftBound;
    public float rightBound;

    public float centerOfScreen; //Y-axis

    private float characterReferenceLeftBound;
    private float characterReferenceRightBound;

    private GameObject player;

    void Start()
    {
        characterReferenceLeftBound = leftBound + 20;
        characterReferenceRightBound = rightBound - 20;
        //this.transform.position = new Vector3(0, 0, -10);
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player.transform.position.x <= characterReferenceLeftBound)
        {
            this.transform.position = new Vector3(characterReferenceLeftBound, centerOfScreen, -10);
            print("LEFT");
        }

        else if (player.transform.position.x >= characterReferenceRightBound)
        {
            print("RIGHT");
            this.transform.position = new Vector3(characterReferenceRightBound, centerOfScreen, -10);
        }
        else
        {
            this.transform.position = new Vector3(followTransform.position.x, centerOfScreen, -10);
        }



    }
}