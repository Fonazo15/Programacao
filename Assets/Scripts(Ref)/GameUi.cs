using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUi : MonoBehaviour
{
    public TextMeshProUGUI currentScoreText;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.ResetCurrentScore();
        UpdateCurrentScore();
    }

    public void AddScore()
    {
        GameManager.Instance.AddScore();
        UpdateCurrentScore();
    }

    public void ReturnMenu()
    {
        GameManager.Instance.LoadScene("MenuScene");
    }

    public void UpdateCurrentScore()
    {
        currentScoreText.text = "Score: " + GameManager.Instance.GetScore();
    }
}
