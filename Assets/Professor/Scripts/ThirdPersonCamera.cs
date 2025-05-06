using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform followTarget;
    public Vector3 followOffset;
    public float sensitivity = 100f;
    public Vector2 pitchValues = new Vector2(-30f, 60f);

    private float _yaw = 0f;
    private float _pitch = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        _yaw += mouseX;
        _pitch -= mouseY;
        _pitch = Mathf.Clamp(_pitch, pitchValues.x, pitchValues.y);

        transform.position = followTarget.position + Quaternion.Euler(_pitch, _yaw, 0) * followOffset;
        transform.LookAt(followTarget.position);
    }
}
