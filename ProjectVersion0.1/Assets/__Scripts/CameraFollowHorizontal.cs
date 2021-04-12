using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowHorizontal : MonoBehaviour
{

    public Transform followTransform;
    public float leftBound;
    public float rightBound;

    private float characterReferenceLeftBound;
    private float characterReferenceRightBound;

    void Start()
    {
        characterReferenceLeftBound = leftBound + 20;
        characterReferenceRightBound = rightBound - 20;
        this.transform.position = new Vector3(0, 0, -10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (followTransform.position.x <= characterReferenceLeftBound)
        {
            this.transform.position = new Vector3(characterReferenceLeftBound, 0, -10);
            //print("LEFT");
        }

        else if (followTransform.position.x >= characterReferenceRightBound)
        {
            //print("RIGHT");
            this.transform.position = new Vector3(characterReferenceRightBound, 0, -10);
        }
        else
        {
            this.transform.position = new Vector3(followTransform.position.x, 0, -10);
        }



    }
}