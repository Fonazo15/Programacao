using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerScore : MonoBehaviour
{
    public UnityEvent IncreseScore;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IncreseScore.Invoke();
        }
    }
}
