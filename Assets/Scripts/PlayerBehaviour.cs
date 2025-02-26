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
    private Position _playerPositionEnum;



    void Update()
    {
        switch(_playerPositionEnum)
        {
            case Position.Left:
                break;
            case Position.Right:
                break;
            case Position.Center:
                break;
        }
    }

    IEnumerator WaitToMove()
    {
        yield return new WaitForSeconds(1f);
    }
}
