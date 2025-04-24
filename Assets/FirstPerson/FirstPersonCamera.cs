using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensitivity = 100.0f;
    public float minPitch = -90f, maxPitch = 90f;

    private float _pitch = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        _pitch -= mouseY;
        _pitch = Mathf.Clamp(_pitch, minPitch, maxPitch);
        transform.localRotation = Quaternion.Euler(_pitch, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
