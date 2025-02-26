using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public float spd;
    public float limitY;
    void Update()
    {
        transform.Translate(Vector2.down * spd * Time.deltaTime);

        if (transform.position.y <= limitY)
            Destroy(this.gameObject);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
