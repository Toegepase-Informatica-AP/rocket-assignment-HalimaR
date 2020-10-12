using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public float thrustMultiplier ;
    public float rotationSpeed;
    private bool applyThrust;

    // Check for rotation keypresses
    void CheckRotationKeys()
    {
        // Rotate left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(rotationSpeed * new Vector3(0, 0, 1));
        }

        // Rotate right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(rotationSpeed * new Vector3(0, 0, -1));
        }
    }

    // Apply thrust to the rocket's rigidbody
    void ApplyRocketThrust()
    {
        if (applyThrust)
        {
            Vector3 force = transform.up * thrustMultiplier;
            GetComponent<Rigidbody>().AddForce(force);
        }
    }

    // Run physics calculations and misc events
    void FixedUpdate()
    {
        applyThrust = Input.GetKey(KeyCode.Space);
        CheckRotationKeys();
        ApplyRocketThrust();
    }
}
