using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyCycle : MonoBehaviour
{
    public Light sunLight;
    public float rotationSpeed = 1f;
    private void Awake()
    {
        sunLight = GetComponent<Light>();
    }
    void Update()
    {
        transform.Rotate(new Vector3(1, 1, 0), rotationSpeed * Time.deltaTime);
    }
}
