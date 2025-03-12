using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "Game RPG/Player Settings")]
public class PlayerData : ScriptableObject
{
    public float playerHp = 100f;
    public float playerStrength = 1f;
    public float playerAttack = 1f;
    public float playerSpeed = 1f;
    public string playerName;
}
