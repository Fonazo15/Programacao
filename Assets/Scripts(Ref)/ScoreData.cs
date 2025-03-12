using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "ScoreData", menuName = "GameData/ScoreData")]
public class ScoreData : ScriptableObject
{
    public int highScore;

    public void ResetHighScore()
    {
        highScore = 0;
    }
}
