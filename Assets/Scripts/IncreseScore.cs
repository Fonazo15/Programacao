using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IncreseScore : MonoBehaviour
{
    public UnityEvent AddScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
            AddScore.Invoke();

    }
}
