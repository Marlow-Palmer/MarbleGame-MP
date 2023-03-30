using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelorometer : MonoBehaviour
{
    //use accelerometer to move ball
    float speed = 10.0f;

    void Update()
    {
        Vector3 dir = Vector3.zero;
        //phone is held parallel to ground

        //xy plane is mapped onto xz plane
        //rotate 90 degrees around y axis
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        //clamp acceleration vector to the marble
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        //make it move 10 meters per second instead of 10 meters per frame
        dir *= Time.deltaTime;

        //move the object
        transform.Translate(dir * speed);
    }
}