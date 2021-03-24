using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    public float angle = 0;
    public int radius = 4;
    float x = 0;
    float y = 0;
    public override void UpdateMovement(){
   
   
    Vector2 direction = Vector2.zero;
   
    x = radius * Mathf.Cos(angle);
    y = radius * Mathf.Sin(angle);
 
    transform.position =new Vector2(x, y);
 
    angle += 0.05f*Mathf.Rad2Deg * Time.deltaTime; //change speed of rotation with the number, be careful it's fast!
         
     } 
}
