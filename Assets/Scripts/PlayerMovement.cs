using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    private bool goingRight;
    public float Speed = 5f; // the Speed of changing Direction
    public float forwardForce = 100f; // the Speed forward Force
    void Update()
    {
        rb.AddForce(0,0, forwardForce * Time.deltaTime); // Add a force on the  z-axis
  
        if (Input.GetKeyDown ("space")&& goingRight == true)  // pressing space going right
        {
          transform.Translate(new Vector3(2,0,0));
        }
        if (Input.GetKeyDown ("space")&& goingRight == false) //pressing space going left
        {
          transform.Translate(new Vector3(-2,0,0));
        }
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
