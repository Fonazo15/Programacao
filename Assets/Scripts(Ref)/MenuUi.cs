using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuUi : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.ResetCurrentScore();
        highScoreText.text = "High Score: " + GameManager.Instance.GetHighScore();
    }

    public void ResetHighScore()
    {
        GameManager.Instance.ResetHighScore();
        highScoreText.text = "High Score: " + GameManager.Instance.GetHighScore();
    }

    public void StartGame()
    {
        GameManager.Instance.LoadScene("GameScene");
    }
}
