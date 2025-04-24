using UnityEngine;

public class Workbench : MonoBehaviour
{
    public int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup") && other.transform.parent == null)
        {
            Destroy(other.gameObject);
            score += 10;
            Debug.Log("Objeto entregue! Pontuação: " + score);
        }
    }
}
