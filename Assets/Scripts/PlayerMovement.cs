using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;

    public float speed = 5f;
    public float sprintSpeed = 8f;
    public float gravity = -25;
    public float groundDistance = 0.4f;
    public float jumpHeight = 1.3f;

    public LayerMask groundMask;

    public bool isGrounded;


    Vector3 velocity;
    
    
    void Update()
    {
        Walk();
        Jump();
    }

    void Walk()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButton("Sprint") && isGrounded && Input.GetAxis("Vertical") > 0)
            speed = sprintSpeed;
        else
            speed = 5f;        
    }

    void Jump()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
