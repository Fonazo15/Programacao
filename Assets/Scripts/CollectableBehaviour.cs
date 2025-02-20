using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{
    
    private void Awake()
    {
        
    }
    private void Update()
    {
        
    }
    void Replace()
    {
        float randomHeight = Random.Range(-0.449f, 4.55f);
        pipe.position = new Vector3(3.07f, randomHeight, 0);
        pipePos = transform.position;
    }
}
