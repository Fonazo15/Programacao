using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyCycle : MonoBehaviour
{
    private Light _sunLight;
    private float _time;

    public float duration = 60f;
    public Gradient lightColor;
    private void Awake()
    {
        _sunLight = GetComponent<Light>();
    }
    void Update()
    {
        _time += Time.deltaTime;

        float timePercent = (_time % duration) / duration;

        float rotationX = Mathf.Lerp(-90f, 270f, timePercent);

        transform.rotation = Quaternion.Euler(rotationX, 0, 0);

        _sunLight.color = lightColor.Evaluate(timePercent);
    }
}
