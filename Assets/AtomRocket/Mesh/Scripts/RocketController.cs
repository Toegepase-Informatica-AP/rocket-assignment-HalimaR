using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    [SerializeField] float thrusterForce = 1000f; //snelheid X
    [SerializeField] float speed = 100f;

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
        float ver = Input.GetAxis("Vertical");
        thrust = Input.GetKey(KeyCode.Space);


        if (!Mathf.Approximately(tilt, 0f))
        {
            rb.freezeRotation = true;                                                           //x, y, z
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0f, 0f, (tilt * speed * Time.deltaTime))));
            
        }else if (!Mathf.Approximately(ver, 0f))
        {
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3((ver * speed * Time.deltaTime), 0f, 0f)));
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
