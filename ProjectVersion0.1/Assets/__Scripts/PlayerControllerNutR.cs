using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerNutR : MonoBehaviour
{
    public Rigidbody2D playerRigidBody;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerRigidBody.velocity = new Vector2(-5, 0);
        }
    }
}
