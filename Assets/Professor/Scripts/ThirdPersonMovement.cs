using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 10f;
    public float jumpForce = 2f;
    public float gravity = -10f;

    public Transform cameraTransform;
    public Animator animator;

    private Vector3 _velocity;
    private CharacterController _controller;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        ApplyGroundCheck();
        HandleJump();
        ApplyGravity();
        HandleMove(GetDirection());
        UpdateMoveAnimation(GetDirection());
    }

    void ApplyGroundCheck()
    {
        if (_controller.isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }
    }

    void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && _controller.isGrounded)
        {
            animator.SetTrigger("Jump");
        }
    }

    public void ApplyJumpForce()
    {
        _velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
    }

    void ApplyGravity()
    {
        _velocity.y += gravity * Time.deltaTime;
    }

    void HandleMove(Vector3 direction)
    {
        Vector3 finalDirection = direction * speed + _velocity;

        if (finalDirection.magnitude > speed)
        {
            finalDirection = finalDirection.normalized * speed;
        }

        _controller.Move(finalDirection * Time.deltaTime);
    }

    Vector3 GetDirection()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(horizontal, 0, vertical).normalized;

        if (inputDirection.magnitude >= 0.1f)
        {
            Vector3 cameraDirection = cameraTransform.TransformDirection(inputDirection);
            cameraDirection.y = 0;

            HandleRotation(cameraDirection);

            return cameraDirection;
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

    public void UpdateMoveAnimation(Vector3 direction)
    {
        float moveAmount = direction.magnitude;
        animator.SetFloat("Speed", moveAmount);
    }
}
