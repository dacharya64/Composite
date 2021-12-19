using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10f;
    public float rotateSpeed = 100f;


    void Start()
    {
        
    }

    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(-transform.right * speed);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(transform.right * speed);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(transform.forward * speed);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(-transform.forward * speed);
        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);

    }
}
