using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public int sceneNumber;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // if the 'R' key is pressed
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }
}
