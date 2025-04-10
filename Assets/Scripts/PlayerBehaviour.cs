using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float spd = 5f;
    public float jump = 2f;
    public float gravity = -10f;

    private CharacterController _controller;
    private Vector3 _velocity;
    void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        HandleGround();
        //HandleVision();
        HandleMovement();
        HandleJump();
        ApplyGravity();
    }
    void HandleMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, _velocity.y, z);

        if(Input.GetButton("Fire3"))
        {
            float sprintSpd = spd * 1.5f;
            _controller.Move(move * sprintSpd * Time.deltaTime);
        }
        else
        {
            _controller.Move(move * spd * Time.deltaTime);
        }
    }
    void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && _controller.isGrounded)
        {
            _velocity.y = jump;
        }
    }
    void ApplyGravity()
    {
        _velocity.y += gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
    }
    void HandleGround()
    {
        if (_controller.isGrounded && _velocity.y < 0)
            _velocity.y = -(jump * 0.75f * Time.deltaTime);
    }
    /*
    void HandleVision()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 targetRotation = new Vector3(mouse.y * -1, 0);
        transform.rotation = Quaternion.Euler(targetRotation);
    }
    */
}
