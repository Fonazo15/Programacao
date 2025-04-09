using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC_PlayerBehaviour : MonoBehaviour
{
    public float spd = 5f;
    public float jump = 2f;
    public float gravity = -10f;

    private CharacterController _controller;
    private Vector3 _velocity;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        HandleGround();
        HandleMovement();
        HandleJump();
        ApplyGravity();
    }

    void HandleMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, _velocity.y, z);
        _controller.Move(move * spd * Time.deltaTime);

        /*
         Vector3 moveDirection = new Vector3 (moveX, 0, moveZ).normalized;

        if (moveDirection.magnitude > 0)
            transform.forward = moveDirection;
        transform.position += moveDirection * spd * Time.deltaTime;
         */
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
            _velocity.y = -(jump * 0.75f);
    }
}
