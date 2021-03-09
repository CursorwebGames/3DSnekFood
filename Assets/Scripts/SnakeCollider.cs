using UnityEngine;

public class SnakeCollider : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You lose!");
        }
        else if (other.CompareTag("Segment"))
        {
            Debug.Log("You win!");
        }
    }
}
