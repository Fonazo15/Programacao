using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpEventRelay : MonoBehaviour
{
    public ThirdPersonMovement personMovement;

    public EnemyBehaviour enemyMovement;

    public void CallJumpForce(bool player)
    {
        if (personMovement != null && player)
        {
            personMovement.ApplyJumpForce();
        }
        else if (enemyMovement != null && !player)
        {
            enemyMovement.EnemyJumpForce();
        }
    }
}
