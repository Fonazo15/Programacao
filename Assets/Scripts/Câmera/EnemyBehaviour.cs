using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float spd;
    public float switchTime = 2f;
    public int direction = 1;

    private float _time;
    //public Vector3[] possibleMoves;
    void Start()
    {
        _time = switchTime;
        //StartCoroutine(EnemyMove());
    }
    private void Update()
    {
        _time -= Time.deltaTime;

        if (_time <= 0 )
        {
            direction *= -1;
            _time = switchTime;
        }
        transform.position += Vector3.right * direction * spd * Time.deltaTime;
    }
    /*
    void RandomMove()
    {
        transform.position = possibleMoves[Random.Range(0, 3)];  //new Vector3 (Mathf.LerpUnclamped(transform.position.x, possibleMoves[Random.Range(0, 3)].x, spd), transform.position.y, Mathf.LerpUnclamped(transform.position.z, possibleMoves[Random.Range(0, 3)].z, spd))
    }
    IEnumerator EnemyMove()
    {
        RandomMove();
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        StartCoroutine(EnemyMove());
    }
    */
}
