using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowVertical : MonoBehaviour
{

    public Transform followTransform;
    public float upBound;
    public float downBound;

    private float _characterReferenceUpBound;
    private float _characterReferenceDownBound;

    void Start()
    {
        _characterReferenceUpBound = upBound - 10;
        _characterReferenceDownBound = downBound + 10;
        this.transform.position = new Vector3(0, 0, -10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (followTransform.position.y >= _characterReferenceUpBound)
        {
            this.transform.position = new Vector3(0, _characterReferenceUpBound, -10);
            //print("UP");
        }

        else if (followTransform.position.y <= _characterReferenceDownBound)
        {
            //print("DOWN");
            this.transform.position = new Vector3(0, _characterReferenceDownBound, -10);
        }
        else
        {
            this.transform.position = new Vector3(0, followTransform.position.y, -10);
        }



    }
}