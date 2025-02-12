using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{
    private Vector2 _startPos;
    private Vector2 _endPos;

    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
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
        float horizontalDirect = Mathf.Abs(swipeDirection.x);
        float verticalDirect = Mathf.Abs(swipeDirection.y);

        if (horizontalDirect > verticalDirect)
        {
            if (swipeDirection.x > 0)
                _spriteRenderer.color = Color.yellow;
            else
                _spriteRenderer.color = Color.red;
        }
        else
        {
            if (swipeDirection.y > 0)
                _spriteRenderer.color = Color.blue;
            else
                _spriteRenderer.color = Color.green;
        }
    }
}
