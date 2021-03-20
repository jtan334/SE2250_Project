using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
      public float speed = 800.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal"); //value of horizontal movement
        float moveVertical = Input.GetAxis ("Vertical"); //value of vertical movement

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical); //movement vector
        GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime); //creates rigid body f
    }
}
