using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f; 
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleForwardMovement();
        HandleSideMovement();
    }

    private void HandleSideMovement()
    {
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed);
        }
    }

    private void HandleForwardMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * speed);
        }
    }
}
