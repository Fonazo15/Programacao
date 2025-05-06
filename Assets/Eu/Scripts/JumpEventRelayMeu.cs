using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpEventRelayMeu : MonoBehaviour
{
    public PlayerBehaviour player;

    public void CallJumpForce()
    {
        if (player != null)
        {
            player.HandleJump();
        }
    }
}
