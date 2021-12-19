using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float force = 20f;

    void Start()
    {
        
    }

    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left * force);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * force);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward * force);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back * force);
    }
}
