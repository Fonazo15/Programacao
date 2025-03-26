using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveLights : MonoBehaviour
{
    public Slider slider;
    private void Awake()
    {
        
    }
    void Update()
    {
        float rotationX = Mathf.Lerp(-90f, 270f, slider.value);

        transform.rotation = Quaternion.Euler(rotationX, 0, 0);
    }
}
