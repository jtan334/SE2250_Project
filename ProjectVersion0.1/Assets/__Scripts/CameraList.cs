using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraList : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        //cam4.SetActive(false);
        //cam5.SetActive(false);
        //cam6.SetActive(false);
    }
}
