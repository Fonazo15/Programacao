using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerBehaviour : MonoBehaviour
{
    public UnityEvent Reset;
    public UnityEvent PlayFlight;
    public Transform player;
    public Rigidbody2D physicsPlayer;

    public float flySpd = 0.01f;
    private float _newHeight;
    void Start()
    {
        player = GetComponent<Transform>();
        physicsPlayer = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.touchCount > 0)
        Jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Pipe"))
        {
            Reset.Invoke();
        }
    }
    void Jump()
    {

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            physicsPlayer.velocity = Vector2.up * flySpd;
        }
    }
}
