using UnityEngine;

public class SnakeCollider : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) gameManager.Lose();
        else if (other.CompareTag("Segment")) gameManager.Win();
    }
}
