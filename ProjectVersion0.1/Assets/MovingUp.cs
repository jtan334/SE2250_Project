using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MovingUp : MonoBehaviour
{
    public Rigidbody2D Character;


    void Awake()
    {
        Character = GetComponent<Rigidbody2D>();
    }
    public void go()
    {
        Character.velocity = new Vector2(Character.velocity.x, Character.velocity.y + 5);
    }
}
