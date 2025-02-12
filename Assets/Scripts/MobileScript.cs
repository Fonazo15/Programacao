using UnityEngine;

public class MobileScript : MonoBehaviour
{
    public Transform ball;
    public float spd = 4.0f;
    private void Start()
    {
        ball = GetComponent<Transform>();
    }
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            
            ball.position = Vector3.Lerp(ball.position, touchPos, spd * Time.deltaTime);
        }
    }
}
