using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workbench : MonoBehaviour
{
    public float score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup") && other.transform.parent == null)
        {
            Destroy(other.gameObject);
            score += 10f;
        }
    }
}
