using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectButton : MonoBehaviour
{
    public UnityEvent PlayGame;

    public Transform PlayButton;
    private void Start()
    {
        PlayButton = GetComponentInChildren<Transform>();
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            gameObject.transform.position = touchPos;

            if(touchPos == PlayButton.position)
            {
                PlayGame.Invoke();
            }
        }
    }
}
