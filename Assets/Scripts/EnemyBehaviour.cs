using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public EnemyData data;
    public CircleCollider2D attackHitbox;
    private void Awake()
    {
        attackHitbox = GetComponentInChildren<CircleCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.K))
            { attackHitbox.enabled = true; }
            else
            {
                attackHitbox.enabled = false;
                data.enemyHp--;
                Debug.Log("Outch");
            }
        }
    }
}
