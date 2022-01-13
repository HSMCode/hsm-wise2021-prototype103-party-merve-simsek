using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float SmoothSpeed = 0.125f;
    public Vector3 offset; 
    bool MoveCamera = true;

    public void FixedUpdate () 
    {
    if(MoveCamera == true)
    
        {
            Vector3 desiredPosition = new Vector3(0, player.position.y + offset.y, player.position.z + offset.z);
            Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed);
            transform.position = SmoothedPosition;
        }

    if (transform.position.z >= 400f)

        {
            MoveCamera = false;
        }
    }
}
