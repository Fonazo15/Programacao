using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    private int _score;

    private void Awake()
    {
        scoreTxt = GetComponent<TextMeshProUGUI>();
    }
    public void IncreaseScore()
    {
        _score++;
        scoreTxt.text = ("Score: " + _score);
    }
}
