using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
            // Variables
    public Rigidbody2D physics;
    public PlayerData data;
    public CircleCollider2D attackHitbox;

            // Unity Functions
    void Awake()
    {
        physics = GetComponent<Rigidbody2D>();
        attackHitbox = GetComponentInChildren<CircleCollider2D>();
    }
    void Update()
    {
        Movement();
        if (data.playerHp <= 0)
            { CheckIfAlive(false); }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if (Input.GetKeyDown(KeyCode.K))
                { attackHitbox.enabled = true; }
            else
            {
                attackHitbox.enabled = false;
                data.playerHp--;
                Debug.Log("Outch");
            }
        }
    }

    // Custom Functions
    void Movement()
    {
        var moveX = Input.GetAxis("Horizontal");
        var moveY = Input.GetAxis("Vertical");
        if (moveX != 0 || moveY != 0)
        {
            transform.Translate(new Vector2 (moveX, moveY) * data.playerSpeed * Time.deltaTime);
        }
    }
    void CheckIfAlive(bool isAlive)
    {
        if (!isAlive)
            { Destroy(this.gameObject); }
        else
            { return; }
    }
            // Events
    public void ChangeName(string name)
    {
        data.name = name;
    }
}
