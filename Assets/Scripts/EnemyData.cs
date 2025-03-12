using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySettings", menuName = "Game RPG/Enemy Settings")]
public class EnemyData : ScriptableObject
{
    public float enemyHp = 10f;
    public float enemyStrength = 1f;
    public float enemyAttack = 1f;
    public float enemySpeed = 0.4f;
    public string enemyName;
}
