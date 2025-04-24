using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed = 5f;
    
    private Vector3 checkpointPosition;

    void Start()
    {
        checkpointPosition = transform.position;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ).normalized;

        if (moveDirection.magnitude > 0)
        {
            transform.forward = moveDirection;
        }

        transform.position += moveDirection * speed * Time.deltaTime;
    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        checkpointPosition = newCheckpoint;
    }

    public void Respawn()
    {
        transform.position = checkpointPosition;
    }
}
