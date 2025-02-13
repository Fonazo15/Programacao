using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public UnityEvent ModifyScore;

    public TextMeshProUGUI scoreTxt;

    public int score = 0;
    private void Start()
    {
        scoreTxt = GetComponent<TextMeshProUGUI>();
    }
    public void ScoreIncrese() 
    { 
        score++;
        scoreTxt.SetText("Score: " + score.ToString());
    }
}
