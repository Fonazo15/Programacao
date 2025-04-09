using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float spd = 4f;
    public Vector3 spawn;
    private void Start()
    {
        spawn = transform.position;
    }
    void Update()
    {
        Move();
    }
    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3 (moveX, 0, moveZ).normalized;

        if (moveDirection.magnitude > 0)
            transform.forward = moveDirection;
        transform.position += moveDirection * spd * Time.deltaTime;
        // Outro jeito \/
        /*
        var moveX = Input.GetAxis("Horizontal") * spd * Time.deltaTime;
        var moveZ = Input.GetAxis("Vertical") * spd * Time.deltaTime;

        if(moveX != 0 || moveZ != 0)
        {
            transform.Translate(new Vector3(moveX, 0, moveZ));
        }
        */
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Checkpoint"))
        {
            spawn = other.transform.position;
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            transform.position = spawn;
        }
    }
}
