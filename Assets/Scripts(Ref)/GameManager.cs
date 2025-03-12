using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public ScoreData scoreData;
    private int _currentScore;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            ResetHighScore();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore()
    {
        _currentScore++;

        if (_currentScore > scoreData.highScore)
        {
            scoreData.highScore = _currentScore;
        }
    }

    public int GetScore()
    {
        return _currentScore;
    }

    public int GetHighScore()
    {
        return scoreData.highScore;
    }

    public void ResetHighScore()
    {
        scoreData.ResetHighScore();
    }

    public void ResetCurrentScore()
    {
        _currentScore = 0;
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
