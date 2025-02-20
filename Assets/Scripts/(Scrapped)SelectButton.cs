using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectButton : MonoBehaviour
{
    public UnityEvent PlayGame;

    public StartGameplay PlayButton;
    private void Awake()
    {
        PlayButton = FindAnyObjectByType<StartGameplay>();
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            gameObject.transform.position = touchPos;

            if(touchPos == PlayButton.gameObject.transform.position)
            {
                PlayGame.Invoke();
            }
        }
    }
}
