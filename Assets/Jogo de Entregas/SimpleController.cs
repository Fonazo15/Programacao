using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    // Primeiro Move
    public float speed = 5f;
    private CharacterController _controller;
    
    // Depois Jump
    public float jumpHeight = 2f;
    public float gravity = -9.81f;
    private Vector3 _velocity;


    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        CheckGround();
        HandleMovement();
        HandleJump();
        ApplyGravity();
    }

    // Primeiro
    void HandleMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, _velocity.y, z);
        _controller.Move(move * speed * Time.deltaTime);
    }

    // Quarto
    void CheckGround()
    {
        if (_controller.isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }
    }

    // Segundo
    void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && _controller.isGrounded)
        {
            _velocity.y = jumpHeight;
        }
    }

    // Terceiro
    void ApplyGravity()
    {
        _velocity.y += gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
    }
}
