using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerBehaviour : MonoBehaviour
{
    public UnityEvent Reset;
    public Transform player;

    private Vector2 playerStartPos;
    public Vector2 playerCurrentPos;

    public float fallSpd = 0.01f;
    void Start()
    {
        player = GetComponent<Transform>();
        playerStartPos = player.position;
    }
    void Update()
    {
        Fall();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Pipe"))
        {
            Reset.Invoke();
        }
    }

    void Fall()
    {

    }
    void Jump()
    {

    }
}
