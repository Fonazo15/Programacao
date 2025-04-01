using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerBehaviour player;
    void Update()
    {
        MoveCam();
    }
    void MoveCam()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, player.transform.position.x, player.spd * Time.deltaTime), transform.position.y, Mathf.Lerp(transform.position.z, player.transform.position.z - 18, player.spd * Time.deltaTime));
    }
}
