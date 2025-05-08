using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Workbench : MonoBehaviour
{
    public int score;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup") && other.transform.parent == null)
        {
            Destroy(other.gameObject);
            score++;
        }
    }
}
