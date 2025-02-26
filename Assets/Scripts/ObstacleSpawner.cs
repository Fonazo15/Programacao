using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject spawnObject;
    public float minTime;
    public float maxTime;
    public Vector2[] lanes;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));

        int randomLane = Random.Range(0, 3);

        Instantiate(spawnObject, lanes[randomLane], Quaternion.identity);

        StartCoroutine(Spawn());
    }
}
