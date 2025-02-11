using UnityEngine;

public class MobileScript : MonoBehaviour
{
    // public Transform ball;
    public SpriteRenderer squere;
    // public float spd = 4.0f;
    private void Start()
    {
        // ball = GetComponent<Transform>();
        squere = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Desafio Swipe (Não Terminado)

            /*
            if (touch.azimuthAngle <= 44 && touch.azimuthAngle >= 316)
            {
                squere.color = Color.red;
                print("Cima: "+squere.color);
            }
            else if (touch.azimuthAngle <= 134 && touch.azimuthAngle >= 46)
            {
                squere.color = Color.green;
                print("Direita: " + squere.color);
            }
            else if (touch.azimuthAngle <= 224 && touch.azimuthAngle >= 136)
            {
                squere.color = Color.blue;
                print("Baixo: " + squere.color);
            }
            else if (touch.azimuthAngle <= 314 && touch.azimuthAngle >= 226)
            {
                squere.color = Color.yellow;
                print("Esquerda: " + squere.color);
            }
            */
            switch (touch.azimuthAngle)
            {
                case <= 134:
                    print("Direita: " + squere.color);
                    break;
                default:
                    print(touch.azimuthAngle);
                    break;
            }


            /*            // Desafio Movimento
             Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

             ball.position = Vector3.Lerp(ball.position, touchPos, spd * Time.deltaTime);

             /*
                        Teste Dificil

             Vector2 ballFirstPlace = ball.transform.position;

             switch (touch.phase)
             {
                 case TouchPhase.Began:
                     print("Toque começou " + ball.transform.position + " " + touch.position);
                     ball.transform.position = touch.position;
                     break;
                 case TouchPhase.Ended:
                     print("Toque Terminou " + ball.transform.position + " " + touch.position);
                     ball.transform.position = ballFirstPlace;
                     break;
             }
            */
        }
    }
}
