using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBehaviour : ThirdPersonMovement
{
    public JumpEventRelay jump;
    Vector3 _velocity;

    void Start()
    {
        StartCoroutine(TimeoutMove(1, 5));
    }
    IEnumerator TimeoutMove(float range1, float range2)
    {
        float finalTime = Random.Range(range1, range2);
        yield return new WaitForSeconds(finalTime);
        finalTime.ConvertTo<int>();
        switch (finalTime)
        {
            case < 3:
                break;
            case 3:
                jump.CallJumpForce(false);
                break;
            case > 3:
                break;

        }
        StartCoroutine(TimeoutMove(range1, range2));
    }
    public void EnemyJumpForce()
    {
        _velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
    }
}
