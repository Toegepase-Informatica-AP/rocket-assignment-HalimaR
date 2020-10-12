using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketcontroller : MonoBehaviour
{
    [SerializeField] float thrusterForce = 10f; //snelheid X
    [SerializeField] float tiltingForce = 10f;

    bool thrust = false;
    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float tilt = Input.GetAxis("Horizontal");
        thrust = Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.Space);
        

        if (!Mathf.Approximately(tilt, 0f))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0f, 0f, (tiltingForce * Time.deltaTime))));
        }
        rb.freezeRotation = false;
    }

    private void FixedUpdate()
    {
        if (thrust)
        {
            rb.AddRelativeForce(Vector3.up * thrusterForce * Time.deltaTime);
        }
    }
}
