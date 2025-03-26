using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSlider : MonoBehaviour
{
    public Scrollbar scrollbar;
    private Vector3 _newPosition;
    public float[] cordenates;

    void Update()
    {
        if (scrollbar.value >= cordenates[1])
            scrollbar.value = cordenates[1];
        else if (scrollbar.value <= cordenates[0])
            scrollbar.value = cordenates[0];

        _newPosition = new Vector3((scrollbar.value * 10f), transform.position.y, transform.position.z);

        transform.position = _newPosition;
    }
}
