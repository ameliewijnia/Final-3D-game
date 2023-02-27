using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    float movementSpeed = 7f;
    [SerializeField]
    float Jumpforce = 6f;

    [SerializeField]
    Transform groundCheck;

    [SerializeField]
    LayerMask ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && GroundCheck())
        {
            rb.velocity = new Vector3(rb.velocity.x, Jumpforce, rb.velocity.z);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
    }

    bool GroundCheck()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
}
