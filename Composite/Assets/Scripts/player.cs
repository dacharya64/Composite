using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10f;
    public float rotateSpeed = 100f;
    public float hitRadius = 2f;

    void Start()
    {
        
    }

    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        // movement and rotation 
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(transform.forward * speed);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(-transform.forward * speed);
        if (Input.GetKey(KeyCode.E))
            rb.AddForce(transform.right * speed);
        if (Input.GetKey(KeyCode.Q))
            rb.AddForce(-transform.right * speed);

        // attacking enemies
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("mouse down");
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, hitRadius);
            Debug.Log(transform.position);
            foreach (var hitCollider in hitColliders)
            {
                Debug.Log(hitCollider);
                if (hitCollider.gameObject.tag == "Enemy") {
                    /*Debug.Log("found a hit");*/
                    /*float dot = Vector3.Dot(transform.forward, (hitCollider.gameObject.transform.position - transform.position).normalized);
                    if (dot > 0.7f)
                    {*/
                    Debug.Log(hitCollider.gameObject.GetComponent<Renderer>().isVisible);
                        if (hitCollider.gameObject.GetComponent<enemy>() != null && hitCollider.gameObject.GetComponent<MeshRenderer>().isVisible)
                        {
                            hitCollider.gameObject.GetComponent<enemy>().health = hitCollider.gameObject.GetComponent<enemy>().health - 2;
                            Debug.Log(hitCollider.gameObject.GetComponent<enemy>().health);
                            if (hitCollider.gameObject.GetComponent<enemy>().health <= 0) {
                                Destroy(hitCollider.gameObject);
                            }
                        }
                    /*}
                    else
                    {
                        Debug.Log("not facing");
                    }*/
                }
            }

            


        }
        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");
    }
}
