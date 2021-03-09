using UnityEngine;

public class SnakeCollider : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.isEnd = true;
            Debug.Log("You lose!");
        }
        else if (other.CompareTag("Segment"))
        {
            gameManager.isEnd = true;
            Debug.Log("You win!");
        }
    }
}
