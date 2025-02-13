using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerBehaviour : MonoBehaviour
{
    public UnityEvent Reset;
    public Transform player;

    public Vector3 playerPos;

    public float flySpd = 0.01f;
    private float _newHeight;
    void Start()
    {
        player = GetComponent<Transform>();
    }
    void Update()
    {
        Jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Pipe"))
        {
            //Reset.Invoke();
        }
    }
    void Jump()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                _newHeight = player.position.y + flySpd;

                playerPos = new Vector3(player.position.x, _newHeight, 0);

                player.position = Vector3.Lerp(player.position, playerPos, flySpd * Time.deltaTime);
            }
        }
    }
}
