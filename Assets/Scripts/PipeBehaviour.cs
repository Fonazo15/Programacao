using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    public Transform pipe;

    Vector2 pipePos = new Vector2();

    public float spd = 1.0f;
    void Start()
    {
        pipe = GetComponent<Transform>();
        pipePos = transform.position;
    }
    void Update()
    {
        pipe.position = pipePos;
        if (pipePos.x <= -2.95)
            ReplacePipes();
        else
            pipePos.x -= spd / 100;
    }
    void ReplacePipes()
    {
        float randomHeight = Random.Range(-0.449f, 4.55f);
        pipe.position = new Vector3(3.07f, randomHeight,0);
        pipePos = transform.position;
    }
}
