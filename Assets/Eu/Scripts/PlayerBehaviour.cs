using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 10f;
    public float jumpHeight = 2f;
    public float gravity = -10f;
    public Transform cameraTransform;

    private CharacterController _controller;
    private Animator _animator;
    private Vector3 _velocity;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        ApplyGroundCheck();
        ApplyGravity();
        HandleMove(GetDirection());
        UpdateMoveAnimation(GetDirection());
    }

    void ApplyGroundCheck()
    {
        if (_controller.isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
                // Remove Jump Trigger
        }
    }

    public void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && _controller.isGrounded)
        {
            _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            // Trigger Animation for Jumping
            _animator.SetTrigger("Jump");
        }
    }

    void ApplyGravity()
    {
        _velocity.y += gravity * Time.deltaTime;
    }

    Vector3 GetDirection()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(horizontal, 0, vertical).normalized;

        if (inputDirection.magnitude >= 0.1f)
        {
            Vector3 direction = cameraTransform.TransformDirection(inputDirection);
            direction.y = 0;

            HandleRotation(direction);
            return direction;
        }

        return Vector3.zero;
    }


    void HandleRotation(Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

    void HandleMove(Vector3 direction)
    {
        Vector3 finalMove = direction * speed + _velocity;

        if (finalMove.magnitude > speed)
        {
            finalMove = finalMove.normalized * speed;
        }

        _controller.Move(finalMove * Time.deltaTime);
    }
    void UpdateMoveAnimation(Vector3 direction)
    {
        var moveAmount = direction.magnitude;
        _animator.SetFloat("Speed", moveAmount);
    }
}
