using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class StartGameplay : MonoBehaviour
{
    public UnityEvent StartGame;

    void Update()
    {
        if(gameObject.GetComponent<BoxCollider2D>())
    }
    public void LoadGameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
