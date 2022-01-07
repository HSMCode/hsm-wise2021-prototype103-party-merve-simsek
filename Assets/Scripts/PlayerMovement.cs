using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    private bool goingRight;
    public float Speed = .04f;
    public float forwardForce= 700f;
    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardForce * Time.deltaTime); // Add a force on the  z-axis
  
        if (goingRight == true) 
        {
           transform.position += Vector3.right * Speed;     
        }  
        else 
        {
          transform.position += Vector3.left * Speed;
        }
  
        if (Input.GetKeyDown ("space")) 
        {
           goingRight  = !goingRight;
        }
    }
}
