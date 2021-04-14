using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CameraFollowVertical : MonoBehaviour
{

    public Transform followTransform;
    public float upBound;
    public float downBound;

    public float centerOfScreen; //X-axis

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
            this.transform.position = new Vector3(centerOfScreen, _characterReferenceUpBound, -10);
            //print("UP");
        }

        else if (followTransform.position.y <= _characterReferenceDownBound)
        {
            //print("DOWN");
            this.transform.position = new Vector3(centerOfScreen, _characterReferenceDownBound, -10);
        }
        else
        {
            this.transform.position = new Vector3(centerOfScreen, followTransform.position.y, -10);
        }



    }
}