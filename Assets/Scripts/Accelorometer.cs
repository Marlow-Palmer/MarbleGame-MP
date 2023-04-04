using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelorometer : MonoBehaviour
{
    //use accelerometer to move ball
    float speed = 20.0f;

    void Update()
    {
        //get accelerometer input
        float x = Input.acceleration.x;
        float y = Input.acceleration.y;

        //calculate movement vector based on input
        Vector3 movement = new Vector3(-x, 0.0f, -y);

        //apply speed to movement vector
        movement *= speed;

        //add velocity to ball based on movement vector
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = movement;
        
    }
}