using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpHeight = 3f;
    public float gravity = -10f;

    public CharacterController controller;

    private Vector3 _velocity;

    void Update()
    {
        Vector3 move = HandleMovement();
        HandleJump();
        controller.Move((move + _velocity) * Time.deltaTime);
    }

    private Vector3 HandleMovement()
    {
        if (controller.isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * vertical + transform.right * horizontal;
        return move.normalized * speed;
    }

    private void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        _velocity.y += gravity * Time.deltaTime;
    }
}
