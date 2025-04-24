using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed = 3f;
    public float switchTime = 2f;
    public int direction = 1;

    private float _timer;

    void Start()
    {
        _timer = switchTime;
    }

    void Update()
    {
        transform.position += Vector3.right * direction * speed * Time.deltaTime;

        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            direction *= -1;
            _timer = switchTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerBehaviour>().Respawn();
        }
    }
}
