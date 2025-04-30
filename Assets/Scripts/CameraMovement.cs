using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float sensitivity = 100f;
    public Vector2 pitchValues = new Vector2(-30f, 60f);

    private float _yaw = 0f;
    private float _pitch = 10f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        _yaw += mouseX;
        _pitch -= mouseY;
        _pitch = Mathf.Clamp(_pitch, pitchValues.x, pitchValues.y);

        transform.position = target.position + Quaternion.Euler(_pitch, _yaw, 0) * offset;
        transform.LookAt(target.position);
    }
}
