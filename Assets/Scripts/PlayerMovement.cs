using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool goingRight;
    public float speed = 10f;
    
    private Rigidbody rb;
    private Vector3 movement;

    void Start()
     {
         rb = GetComponent<Rigidbody>();
     }
    void Update()
    {         
         movement = ( transform.forward) * speed; // multiply by speed and you got your movement ready
         
        if (Input.GetKeyDown ("space")&& goingRight == true)  // pressing space going right
        {
          transform.Translate(new Vector3(2,0,0));
        }
        if (Input.GetKeyDown ("space")&& goingRight == false) //pressing space going left
        {
          transform.Translate(new Vector3(-2,0,0));
        }
    }

    private void FixedUpdate()
    {
         rb.velocity = new Vector3(movement.x , rb.velocity.y, movement.z);
    }

    void OnCollisionEnter (Collision other)
    {
      if (other.gameObject.CompareTag ("Right")) //right wall Collision Bool is changing to false, Player movement left
      {
        goingRight = false;
        Debug.Log ("going right false" + gameObject.name + other.gameObject.name);
      }
       if (other.gameObject.CompareTag ("Left")) //left wall Collision Bool is changing to true, Player movement right
      {
        goingRight = true;
        Debug.Log ("going left true");
      }
    }
    
}
