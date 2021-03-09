using UnityEngine;
using UnityEngine.UI;

public class GetScoreText : MonoBehaviour
{
    public GameManager gameManager;
    public Text text;

    private void Start()
    {
        text.text = $"Score: {gameManager.score}";
    }
}
