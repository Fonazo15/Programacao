using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    public float spd = 5f;
    void Update()
    {
        Vector3 targetPosition = playerTransform.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, spd * Time.deltaTime);
        //LookAtMouse();
    }
    /*
    void LookAtMouse()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 targetRotation = new Vector3(mouse.y * -1, mouse.x * -1);
        if (targetRotation.y <= 90 || targetRotation.y >= -90)
            transform.rotation = Quaternion.Euler(targetRotation);
    }
    */
}
