using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreData", menuName = "Game Manager/Score Data")]
public class ScoreData : ScriptableObject
{
    public int highScore;

    public void ResetHighScore()
    {
        highScore = 0;
    }
}
