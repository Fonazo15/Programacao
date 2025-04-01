using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float spd = 4f;
    void Update()
    {
        Move();
    }
    void Move()
    {
        var moveX = Input.GetAxis("Horizontal") * spd * Time.deltaTime;
        var moveZ = Input.GetAxis("Vertical") * spd * Time.deltaTime;

        if(moveX != 0 || moveZ != 0)
        {
            transform.Translate(new Vector3(moveX, 0, moveZ));
        }
    }
}
