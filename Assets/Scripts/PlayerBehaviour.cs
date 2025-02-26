using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public enum Position
    {
        Left,
        Right,
        Center
    }
    public Position playerPositionEnum;

    private Vector2 _startPos;
    private Vector2 _endPos;

    public Vector2 playerEndPointRight = new Vector2(1.65f, -3.81f);
    public Vector2 playerEndPointLeft = new Vector2(-1.65f, -3.81f);
    public Vector2 playerEndPointCenter = new Vector2(0f, -3.81f);

    void Awake()
    {
        if(playerPositionEnum == Position.Left)
        {
            gameObject.transform.position = playerEndPointLeft;
        }
        else if (playerPositionEnum == Position.Right)
        {
            gameObject.transform.position = playerEndPointRight;
        }
        else
        {
            gameObject.transform.position = playerEndPointCenter;
        }
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
                _startPos = touch.position;
            else if (touch.phase == TouchPhase.Ended)
            {
                _endPos = touch.position;
                EvaluateSwipe();
            }
        }
    }

    void EvaluateSwipe()
    {
        Vector2 swipeDirection = _endPos - _startPos;
        float horizontalDirect = swipeDirection.x;
        Vector2 playerLastPos = gameObject.transform.position;

        if (horizontalDirect > 0 && playerPositionEnum == Position.Left)
        {
            gameObject.transform.position = Vector2.Lerp(playerLastPos, playerEndPointCenter, 3f);
            playerPositionEnum = Position.Center;
        }
        else if (horizontalDirect < 0 && playerPositionEnum == Position.Center)
        {
            gameObject.transform.position = Vector2.Lerp(playerLastPos, playerEndPointRight, 3f);
            playerPositionEnum = Position.Left;
        }
        else if (horizontalDirect < 0 && playerPositionEnum == Position.Right)
        {
            gameObject.transform.position = Vector2.Lerp(playerLastPos, playerEndPointCenter, 3f);
            playerPositionEnum = Position.Center;
        }
        else if (horizontalDirect > 0 && playerPositionEnum == Position.Center)
        {
            gameObject.transform.position = Vector2.Lerp(playerLastPos, playerEndPointLeft, 3f);
            playerPositionEnum = Position.Right;
        }
    }
}
