using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public ScoreData scoreData;

    public int currentScore;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }
    public void IncreseScore()
    {
        currentScore++;

        if (currentScore > scoreData.highScore)
        {
            scoreData.highScore = currentScore;
        }
    }
    public int GetScore()
        { return currentScore; }
    public int GetHighScore()
        { return scoreData.highScore; }
    public void ResetHighScore()
        { scoreData.ResetHighScore(); }
    public void LoadScene(string sceneName)
        { SceneManager.LoadScene(sceneName); }
}